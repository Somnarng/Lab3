using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{

    public Transform player;
    [SerializeField] private int speed = 2;

    private void OnEnable()
    {
        
            var rotation = player.rotation;
            transform.rotation = rotation;
            transform.position = player.position;
        
    }

    void Update()
    {
        var rotation = player.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        transform.position = player.position;

    }
}