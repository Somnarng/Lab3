using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]

public class ObjectHighlighter : MonoBehaviour

{
    [SerializeField] private Color _outlineColor = Color.white;
    [SerializeField] private float _outlineWidth = 0.05f;
    [SerializeField] private float _outlineZTest = 1f;

    private Mesh _mesh;
    private Material _material;
    private MeshFilter _meshFilter;

    private void Awake()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _mesh = _meshFilter.sharedMesh;
        _material = GetComponent<Renderer>().sharedMaterial;
    }

    private void OnRenderObject()
    {
        // Set the material's properties
        _material.SetPass(0);
        _material.SetColor("_OutlineColor", _outlineColor);
        _material.SetFloat("_OutlineWidth", _outlineWidth);
        _material.SetFloat("_ZTest", _outlineZTest);

        // Draw the mesh
        Graphics.DrawMeshNow(_mesh, transform.localToWorldMatrix, 0);
    }
}