using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public int trashGathered;
    public bool trashStart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trashStart = PixelCrushers.DialogueSystem.DialogueLua.GetVariable("Convo1Done").asBool;
        trashGathered = PixelCrushers.DialogueSystem.DialogueLua.GetVariable("TrashGotten").asInt;
        text.text = trashGathered + "/4 Trash Collected";

    }
}
