using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {   
        // The input values can be obtained from the vertical and horizontal
        // axes using these lines. These axes are mapped by Unity by default
        // to the arrow keys and the 'W', 'A', 'S', and 'D' keys. This allows
        // for smooth movement input.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // As a result, a vector indicating the direction of movement is created.
        // To guarantee that the cube moves solely on the X and Z axes—that is,
        // without moving vertically—the Y component is set to 0.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}