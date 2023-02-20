using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBagHold : MonoBehaviour
{
    public Transform player;
    public Transform target;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = target.position;
        var lookPos = player.position - transform.position;
        lookPos.y = 0;
        lookPos.x = 0;
    }
}
