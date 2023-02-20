using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructable : MonoBehaviour
{
    [SerializeField] private int _health;

void HealthCheck()
    {
        if(_health <= 0)
        {
            Debug.Log("Destroying Object!");
            Destroy();
        }
    }

public void Damage()
    {
        _health--;
        HealthCheck();
    }

    public abstract void Destroy();
}
