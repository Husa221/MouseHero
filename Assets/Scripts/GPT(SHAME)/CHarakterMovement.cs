using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHarakterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;       // Movement speed
    public Rigidbody2D rb;             // Character's Rigidbody2D
    private float moveInput;

    void Update()
    {
        // Get horizontal input (A/D keys or Left/Right arrows)
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {

        //rb.AddForce(new Vector2(moveInput * moveSpeed, rb.velocity.y), ForceMode2D.Force);
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y); 
    }

  
}
