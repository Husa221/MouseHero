using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPTplayer : MonoBehaviour
{
  
    public float moveSpeed = 5f;       // Speed of character movement
    public Rigidbody2D rb;             // Reference to the Rigidbody2D component of the mouse character

    private Vector2 movement;

    void Update()
    {
        // Get player input (Horizontal and Vertical input for debugging or future use)
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Apply movement to the character
        rb.velocity = movement * moveSpeed;
    }

}
