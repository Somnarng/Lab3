using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPositionSet : MonoBehaviour
{
  [SerializeField]  private CinemachineVirtualCamera vcam;
  [SerializeField] private GameObject target;


public void UpdatePos()
    {
        vcam.transform.position = target.transform.position;
        vcam.transform.rotation = target.transform.rotation;
    }
}
