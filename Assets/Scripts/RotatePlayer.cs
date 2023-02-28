using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotatePlayer : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;

    public void LookAtTargetObject()
    {
        Vector3 targetRotation = virtualCamera.transform.rotation.eulerAngles;
        targetRotation.x = 0f;
        targetRotation.z = 0f;
        transform.rotation = Quaternion.Euler(targetRotation);
        transform.position = new Vector3(virtualCamera.transform.position.x, transform.position.y, virtualCamera.transform.position.z);
    }
}