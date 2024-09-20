using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        objectRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
