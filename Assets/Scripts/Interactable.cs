using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private bool _playerWithinRange;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _playerWithinRange = true;
        }
    }
    private void Update()
    {
        if (_playerWithinRange)
        {
            Activate();
        }
    }
    public virtual void Activate()
    {

    }
    public virtual void Deactivate()
    {

    }
}
