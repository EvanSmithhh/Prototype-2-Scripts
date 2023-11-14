using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 10.0f;
    public float zBoundaryBottom = 1.0f;
    public float zBoundaryTop = 15.0f;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Prevents the player from leaving the boundaries
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zBoundaryBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundaryBottom);
        }
        if (transform.position.z > zBoundaryTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundaryTop);
        }

            // Shoots a sandwich out of the player when space is pressed
            if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // Moves player left and right based on horizontal controls
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        // Moves player forward and backward based on vertical controls
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
    }
}
