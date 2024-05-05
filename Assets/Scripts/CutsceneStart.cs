using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

[RequireComponent (typeof (BoxCollider))]
[RequireComponent(typeof(SignalReceiver))]
public class CutsceneStart : Interactable
{
    [SerializeField] private GameObject _cutsceneToPlay;
    [SerializeField] private bool oneTime;

    public override void Activate()
    {
        base.Activate();
        _cutsceneToPlay.SetActive(true);
        PlayerController.Instance.CutsceneCamera.SetActive(true);
    }

    public override void Deactivate()
    {
        base.Deactivate();
        PlayerController.Instance.CutsceneCamera.SetActive(false);

        if (oneTime)
        {
            Destroy(_cutsceneToPlay);
            Destroy(this.gameObject);
        }
    }
    //code based off: https://www.youtube.com/watch?v=KxHM9vtKElI
}
