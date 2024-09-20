using System.Collections;
using UnityEngine;

public class HeartDrawer : MonoBehaviour
{
    public GameObject spherePrefab;  // Reference to the sphere prefab
    public float drawingSpeed = 0.1f;  // Time between drawing points
    public float heartRadius = 1f;   // Scaling factor for the heart shape

    private bool isDrawing = false;  // Flag to control drawing
    private float theta = 0f; // Angle for polar coordinates

    void Update()
    {
        // Toggle drawing when pressing the 'H' key
        if (Input.GetKeyDown(KeyCode.H))
        {
            isDrawing = !isDrawing;
            if (isDrawing)
            {
                StartCoroutine(DrawHeart());
            }
        }
    }

    IEnumerator DrawHeart()
    {
        while (isDrawing)
        {
            // Calculate polar coordinates for the heart shape
            float r = 1 + Mathf.Cos(theta);
            float x = r * Mathf.Cos(theta) * heartRadius;
            float z = r * Mathf.Sin(theta) * heartRadius;
            Vector3 heartPosition = new Vector3(x, 0, z);

            // Move the cube to the new position
            transform.position = heartPosition;

            // Instantiate the sphere at the trail position
            GameObject trail = Instantiate(spherePrefab, transform.position, Quaternion.identity);

            // Set a random color for the sphere
            Renderer renderer = trail.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = new Color(Random.value, Random.value, Random.value);
            }
            else
            {
                Debug.LogWarning("No Renderer component found on the instantiated sphere prefab.");
            }

            Destroy(trail, 50f); // Destroy the sphere after 5 seconds

            // Increment theta
            theta += drawingSpeed;

            // Wait until the next frame
            yield return null;
        }
    }
}