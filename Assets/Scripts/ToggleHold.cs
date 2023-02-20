using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHold : MonoBehaviour
{
    [SerializeField] private List<GameObject> myList;

    private int currentActiveIndex = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Toggle();
        }
    }
    void Toggle()
    {
        myList[currentActiveIndex].SetActive(false);
        currentActiveIndex++;
        if (currentActiveIndex >= myList.Count)
            currentActiveIndex = 0;
        myList[currentActiveIndex].SetActive(true);
    }
}
