using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightInteractable : MonoBehaviour
{
    public Material _highlightMaterial;
    private Material _defaultMaterial;

    private bool _isHighlighted = false;

    public Camera _cam;
    public float maxRaycastDistance = 5f;

    void Start()
    {
        _defaultMaterial = GetComponent<Renderer>().material;
        _cam = Camera.main;
    }

    void Update()
    {
        // Create a ray from the FPS _camera's position and direction
        Ray ray = _cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        // Check if the ray hits this object
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxRaycastDistance) && hit.transform == transform)
        {
            if (!_isHighlighted)
            {
                GetComponent<Renderer>().material = _highlightMaterial;
                _isHighlighted = true;
            }
        }
        else
        {
            if (_isHighlighted)
            {
                GetComponent<Renderer>().material = _defaultMaterial;
                _isHighlighted = false;
            }
        }
    }
}
