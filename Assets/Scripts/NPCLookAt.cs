using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLookAt : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private int speed = 5;
    private bool DialogueIN = false;
    private bool rotatedBack = true;
    [SerializeField]
    public Quaternion defRot;
    private void Start()
    {
        defRot = transform.rotation;
    }
    void Update()
    {

        if (DialogueIN == true)
        {
            CancelInvoke();
            var lookPos = player.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
            rotatedBack = false;
        }
        else if(DialogueIN == false && rotatedBack == false) { 
            Invoke("ResetPos", 2f);
        }
    }

    public void DiFlip()
    {
        DialogueIN = !DialogueIN;
    }
    public void DiTrue()
    {
        DialogueIN = true;
    }
    public void DiFalse()
    {
        DialogueIN = false;
    }
    public void ResetPos()
    {
       var defRotation = defRot;
        transform.rotation = Quaternion.Slerp(transform.rotation, defRotation, Time.deltaTime * speed);
        rotatedBack = true;
    }
}
