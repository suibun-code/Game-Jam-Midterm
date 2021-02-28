using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum CurrentColor
{
    RED,
    GREEN,
    BLUE,
    PURPLE
}

public class Player : MonoBehaviour
{
    public int health = 3;

    public CurrentColor currentColor = CurrentColor.RED;

    public bool isGrounded = true;

    [SerializeField] private Material[] materials = null;
    private MeshRenderer meshRenderer = null;

    //Components
    private Rigidbody rigidBody;

    //References
    private Transform playerTransform;

    [SerializeField] private float jumpForce = 10;

    private void Awake()
    {
        playerTransform = transform;
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }

    public void OnChangeColorRed(InputValue value)
    {
        currentColor = CurrentColor.RED;
        meshRenderer.material = materials[(int)currentColor];
    }

    public void OnChangeColorGreen(InputValue value)
    {
        currentColor = CurrentColor.GREEN;
        meshRenderer.material = materials[(int)currentColor];
    }

    public void OnChangeColorBlue(InputValue value)
    {
        currentColor = CurrentColor.BLUE;
        meshRenderer.material = materials[(int)currentColor];
    }

    public void OnChangeColorPurple(InputValue value)
    {
        currentColor = CurrentColor.PURPLE;
        meshRenderer.material = materials[(int)currentColor];
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
}
