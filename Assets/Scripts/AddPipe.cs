using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPipe : MonoBehaviour
{
   [SerializeField] private GameObject pipe;
    public void PipeInteract()
    {
        ToggleHold toggleHoldScript = FindObjectOfType<ToggleHold>();
        toggleHoldScript.myList.Add(pipe);
    }
}
