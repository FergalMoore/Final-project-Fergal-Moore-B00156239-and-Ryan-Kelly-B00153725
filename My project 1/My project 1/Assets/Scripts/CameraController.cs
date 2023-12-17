using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    
    // Initializes the offset by subtracting the target's position from the camera's position.
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Smoothly follows the target in LateUpdate, using Vector3.Lerp for a gradual transition.
    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x,transform.position.y, offset.z+target.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, 10 * Time.deltaTime);//newPosition
    }
}
