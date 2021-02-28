using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum CurrentColor
{
    RED,
    GREEN,
    BLUE
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
        meshRenderer.material = materials[0];
    }

    public void OnChangeColorGreen(InputValue value)
    {
        currentColor = CurrentColor.GREEN;
        meshRenderer.material = materials[1];
    }

    public void OnChangeColorBlue(InputValue value)
    {
        currentColor = CurrentColor.BLUE;
        meshRenderer.material = materials[2];
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
