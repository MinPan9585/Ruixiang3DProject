using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform target;
    public Vector3 offsetAngle = new Vector3(90, 0, 0);
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.position);
            transform.Rotate(offsetAngle);
        }
    }
}
