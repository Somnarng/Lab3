using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
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

void Damage()
    {
        _health--;
    }

void Destroy()
    {
        this.gameObject.SetActive(false);
    }
}
