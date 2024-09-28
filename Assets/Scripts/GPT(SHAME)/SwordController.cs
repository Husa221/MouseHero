using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public Transform character;

    public float rotationSpeed = 100f;


    void Update()
    {
        // Get input from the player to rotate the sword
        float rotationInput = Input.GetAxis("Vertical"); // W/S or Up/Down keys



        transform.RotateAround(character.position, Vector3.forward, rotationInput * rotationSpeed * Time.deltaTime);

    }
}
    
