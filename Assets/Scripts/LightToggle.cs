using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _flashlight;
    void Update()
    {
        if (_target.activeInHierarchy)
        {
            _flashlight.SetActive(true);
        }
        else
        {
            _flashlight.SetActive(false);
        }
    }
}
