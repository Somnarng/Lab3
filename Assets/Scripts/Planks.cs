using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planks : Destructable
{
    public float fadeTime = 2f;
    public float destroyTime = 0.5f;

    private Rigidbody rb;
    private Material material;
    private HighlightInteractable HI;
    public DoorActivator doorActivator;

    private float initialAlpha;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        material = GetComponent<Renderer>().material;
        HI = GetComponent<HighlightInteractable>();
        doorActivator = FindObjectOfType<DoorActivator>();
        rb.isKinematic = true;

        initialAlpha = material.color.a;
    }
    public override void Destroy()
    {
        rb.isKinematic = false;
        HI.enabled = false;
        GetComponent<Renderer>().material = material;
        StartCoroutine(FadeOut());
        doorActivator?.planks.Remove(this.gameObject);
    }
    IEnumerator FadeOut()
    {

        float alphaDelta = initialAlpha / (fadeTime / Time.deltaTime);

        // Fade out the object over time
        while (material.color.a > 0)
        {
            Color newColor = material.color;
            newColor.a -= alphaDelta;
            material.color = newColor;
            yield return null;
        }

        // Set the object to be destroyed after
        Destroy(gameObject, destroyTime);
    } //adapted code from W3
}
