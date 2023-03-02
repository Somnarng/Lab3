using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDefLook : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private int speed = 5;
    private bool DialogueIN = false;
    void Update()
    {

        if (DialogueIN == true)
        {
            CancelInvoke();
            var lookPos = player.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        }
        else if (DialogueIN == false)
        {
        }
    }

    public void DiFlip2()
    {
        DialogueIN = !DialogueIN;
    }
}