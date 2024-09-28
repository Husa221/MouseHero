using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] int anglePrecise;
    private void Update()
    {
       Vector3 look = transform.InverseTransformPoint(target.transform.position);
        float angle = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg - anglePrecise;
        transform.Rotate(0, 0, angle);
    }
}
