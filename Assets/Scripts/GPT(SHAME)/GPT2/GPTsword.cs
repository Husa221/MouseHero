using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPTsword : MonoBehaviour
{
    public Transform character;        // Reference to the mouse character
    public float rotationSpeed = 100f; // Speed of sword rotation
    public float pushForce = 500f;     // Force applied to the character when the sword touches the ground
    private Rigidbody2D characterRb;   // Reference to the Rigidbody2D of the character

    private bool isTouchingGround = false;  // To track if the sword is touching the ground

    void Start()
    {
        characterRb = character.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input to rotate the sword (e.g., W/S or Arrow keys)
        float rotationInput = Input.GetAxis("Vertical"); // W/S keys or Arrow keys for rotation

        // Rotate the sword around the character
        transform.RotateAround(character.position, Vector3.forward, rotationInput * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the sword hits the ground or obstacle
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingGround = true;

            // Calculate the direction opposite to the contact point (to push the mouse)
            Vector2 contactPoint = collision.contacts[0].point;
            Vector2 pushDirection = ((Vector2)character.position - contactPoint).normalized;

            // Apply force to the character in the direction opposite to the collision
            characterRb.AddForce(pushDirection * pushForce);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Stop pushing when sword leaves the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingGround = false;
        }
    }

}
