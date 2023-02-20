using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorActivator : MonoBehaviour
{
    private int planksDestroyed = 0;
    public string nextSceneName;
    public void PlankDestroyed()
    {
        planksDestroyed++;

        if (planksDestroyed >= 3)
        {
            gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    public void Interact()
    {
        if (planksDestroyed >= 3)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

