using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    public GameObject spherePrefab;  // Reference to the sphere prefab
    public float trailInterval = 0.1f; // Time interval between trail spheres
    private float timeSinceLastTrail;

    void Update()
    {
        // Update the timer
        timeSinceLastTrail += Time.deltaTime;

        // Check if any movement keys are pressed and if it's time to create a new sphere
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ||
             Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
            && timeSinceLastTrail >= trailInterval)
        {
            // Create a new sphere at the current position of the cube
            GameObject trail = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            trail.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            Destroy(trail, 5f); // Destroy the sphere after 5 seconds

            // Reset the timer
            timeSinceLastTrail = 0f;
        }
    }
}