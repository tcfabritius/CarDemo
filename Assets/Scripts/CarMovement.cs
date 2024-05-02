using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10f; // Speed of the car
    public float rotationSpeed = 100f; // Rotation speed of the car

    void Update()
    {
        // Move the car forward/backward
        float moveInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);

        // Rotate the car left/right
        float rotateInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotateInput * rotationSpeed * Time.deltaTime);
    }
}
