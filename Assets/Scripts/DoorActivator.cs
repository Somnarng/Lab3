using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorActivator : MonoBehaviour
{
    public List<GameObject> planks = new List<GameObject>();
    public bool planksDestroyed = false;
    public string nextSceneName;

    public void Update()
    {
        if(planks == null || planks.Count <= 0)
        {
            planksDestroyed = true;
            gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    public void Interact()
    {
        if (planksDestroyed == true)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

