using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnKeyPress : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}