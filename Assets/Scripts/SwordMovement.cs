using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    [SerializeField] GameObject target;

    [SerializeField] float swordSpeed;
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.forward, swordSpeed * Time.deltaTime);
    }
}
