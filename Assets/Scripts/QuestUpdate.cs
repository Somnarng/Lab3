using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestUpdate : MonoBehaviour
{
    public int currentQuestState;
    public TMP_Text questText;
   [SerializeField] private Animator anim;

    public void StartQuest()
    {
        currentQuestState = 0;
        anim.SetBool("QuestStart", true);
    }
    private void Update()
    {

        switch (currentQuestState)
        {
            case 0:
                questText.text = "Find a way to break the boards.";
                break;
            case 1:
                questText.text = "Locate the broadcast room.";
                break;
            case 2:
                questText.text = "Investigate the room.";
                break;
            case 3:
                questText.text = "Find the code.";
                break;
            case 4:
                questText.text = "Input the code: 04115.";
                break;
            case 5:
                questText.text = "Incapacitate the Stranger.";
                break;
            default:
                questText.enabled = false;
                break;
        }
    }
    public void AdvanceQuest()
    {
        currentQuestState++;
    }
}
