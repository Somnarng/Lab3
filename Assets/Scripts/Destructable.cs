using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructable : MonoBehaviour
{
    [SerializeField] private int _health;

    public void Damage()
    {
        _health--;
        HealthCheck();
    }
    void HealthCheck()
    {
        if(_health <= 0)
        {
            Debug.Log("Destroying Object!");
            Destroy();
        }
    }


    public abstract void Destroy();
}
