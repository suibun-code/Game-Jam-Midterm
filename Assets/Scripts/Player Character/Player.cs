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

    public bool isJumping = false;
    public CurrentColor currentColor = CurrentColor.RED;
    public int lives = 30;

    //Components
    private Transform _playerTransform;
    private Rigidbody _rigidBody;
    private MeshRenderer _meshRenderer;
    private Animator _animator;

    //Animator Hashes
    private readonly int IsJumpingHash = Animator.StringToHash("IsJumping");

    private void Awake()
    {
        _playerTransform = transform;
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidBody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    void Start()
    {
        livesText.SetText("Lives: " + lives);
    }

    public void OnChangeColorRed(InputValue value)
    {
        currentColor = CurrentColor.RED;
        _meshRenderer.material.SetColor("_Color", new Color32(184, 15, 10, 255));
    }
    public void OnChangeColorGreen(InputValue value)
    {
        currentColor = CurrentColor.GREEN;
        _meshRenderer.material.SetColor("_Color", new Color32(50, 205, 50, 255));
    }
    public void OnChangeColorBlue(InputValue value)
    {
        currentColor = CurrentColor.BLUE;
        _meshRenderer.material.SetColor("_Color", new Color32(65, 105, 225, 255));
    }
    public void OnChangeColorPurple(InputValue value)
    {
        currentColor = CurrentColor.PURPLE;
        _meshRenderer.material.SetColor("_Color", new Color32(102, 51, 153, 255));
    }
    public void OnJump(InputValue value)
    {
        if (!isJumping)
        {
            isJumping = value.isPressed;
            _animator.SetBool(IsJumpingHash, isJumping);
            _rigidBody.AddForce(_playerTransform.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
            isJumping = false;

            _animator.SetBool(IsJumpingHash, isJumping);
        }
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

        if (other.tag == "Obstacle")
        {
            lives -= 1;

            if (lives <= 0)
                SceneManager.LoadScene("MainMenu");
        }

        livesText.SetText("Lives: " + lives);
    }
}
