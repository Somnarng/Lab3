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
        PlayerController.Instance.CutscenePlayerCamera.SetActive(true);
        PlayerController.Instance.FirstPersonCamera.SetActive(false);
    }

    public override void Deactivate()
    {
        base.Deactivate();
        PlayerController.Instance.CutsceneCamera.SetActive(false);
        PlayerController.Instance.CutscenePlayerCamera.SetActive(false);
        PlayerController.Instance.FirstPersonCamera.SetActive(true);

        if (oneTime)
        {
            Destroy(_cutsceneToPlay);
            Destroy(this.gameObject);
        }
    }
    //code based off: https://www.youtube.com/watch?v=KxHM9vtKElI
}
