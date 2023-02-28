using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class Enemy : Destructable
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject convoStart;
        public override void Destroy()
        {
        anim.SetTrigger("Down");
        //play death animation 
        Invoke(nameof(ConvoTrigger), 5f);
    }

    public void ConvoTrigger()
    {
        convoStart.SetActive(true);
    }

    }