using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WeaponControl : MonoBehaviour
{
    // Point you want to have sword rotate around
    public Transform shoulder;

    // how far you want the sword to be from point
    public float armLength = 3f;

    void Start()
    {
        // if the sword is child object, this is the transform of the character (or shoulder)
        shoulder = transform.parent.transform;
    }

    void Update()
    {

        // Get the direction between the shoulder and mouse (aka the target position)
        Vector3 shoulderToMouseDir =
            Camera.main.ScreenToWorldPoint(Input.mousePosition) - shoulder.position;
        shoulderToMouseDir.z = 0; // zero z axis since we are using 2d

        // we normalize the new direction so you can make it the arm's length
        // then we add it to the shoulder's position
        transform.position = shoulder.position + (armLength * shoulderToMouseDir.normalized);
        //transform.rotation.LookAt(target);
    }


}
