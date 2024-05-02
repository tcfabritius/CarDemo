using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the car's transform
    public float height = 5f; // Height of the camera above the car
    public float distance = 20f; // Distance behind the car

    void LateUpdate()
    {
        if (target == null)
            return;

        // Calculate the desired position of the camera
        Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5f);

        // Make the camera look at the car
        transform.LookAt(target.position);
    }
}
