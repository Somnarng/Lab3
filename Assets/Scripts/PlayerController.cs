using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    [SerializeField] private StarterAssets.FirstPersonController _firstPersonController;
    [SerializeField] private PixelCrushers.DialogueSystem.Wrappers.Selector _selector;
    [SerializeField] private GameObject _playerModel;

    public GameObject FirstPersonCamera;
    public GameObject CutsceneCamera;
    public GameObject CutscenePlayerCamera;

    private void Awake()
    {
        Instance = this;
    }
    public void Activate()
    {
        _firstPersonController.enabled = true;
        _selector.enabled = true;
        _playerModel.SetActive(true);
    }
    public void Deactivate()
    {
        _firstPersonController.enabled = false;
        _selector.enabled = false;
        _playerModel.SetActive(false);
    }
}
