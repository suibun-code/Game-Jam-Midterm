using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //TEXT
    public TextMeshProUGUI livesText;

    //PLAYER VARIABLES
    private float jumpForce = 15;
    private float score = 0;
    private int combo = 0;
    private float scoreMultiplier = 1.0f;
    private bool isGrounded = true;

    public CurrentColor currentColor = CurrentColor.RED;
    public int lives = 30;

    //Components
    private Transform playerTransform;
    private Rigidbody rigidBody;
    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        playerTransform = transform;
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        livesText.SetText("Lives: " + lives);
    }

    public void OnChangeColorRed(InputValue value)
    {
        currentColor = CurrentColor.RED;
        meshRenderer.material.SetColor("_Color", new Color32(184, 15, 10, 255));
    }
    public void OnChangeColorGreen(InputValue value)
    {
        currentColor = CurrentColor.GREEN;
        meshRenderer.material.SetColor("_Color", new Color32(50, 205, 50, 255));
    }
    public void OnChangeColorBlue(InputValue value)
    {
        currentColor = CurrentColor.BLUE;
        meshRenderer.material.SetColor("_Color", new Color32(65, 105, 225, 255));
    }
    public void OnChangeColorPurple(InputValue value)
    {
        currentColor = CurrentColor.PURPLE;
        meshRenderer.material.SetColor("_Color", new Color32(102, 51, 153, 255));
    }
    public void OnJump(InputValue value)
    {
        if (isGrounded)
            rigidBody.AddForce(playerTransform.up * jumpForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ground")
            isGrounded = true;
    }
    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "Ground")
            isGrounded = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Barrier")
        {
            var barrier = other.GetComponent<BarrierBehaviour>();

            if (barrier.currentColor == currentColor)
            {
                combo += 1;
                scoreMultiplier = 1 + combo / 20;
            }
            else
            {
                lives -= 1;

                if (lives <= 0)
                    SceneManager.LoadScene("MainMenu");

                combo = 0;
                scoreMultiplier = 0;
            }
        }

        livesText.SetText("Lives: " + lives);
    }
}
