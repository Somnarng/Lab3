using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Canvas pauseCanvas;
    [SerializeField] private bool isPaused = false;

    [SerializeField] private StarterAssets.FirstPersonController firstPersonController;
    [SerializeField] private PixelCrushers.DialogueSystem.Wrappers.Selector selector;

    public void Awake()
    {
        firstPersonController = FindObjectOfType<StarterAssets.FirstPersonController>();
        selector = FindObjectOfType<PixelCrushers.DialogueSystem.Wrappers.Selector>();
        Pause();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FlipBool();
            Pause();
        }
    }
    public void FlipBool()
    {
        isPaused = !isPaused;
    }
    public void Pause()
    {
        if (isPaused == true)
        {
            Time.timeScale = 0;
            pauseCanvas.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            firstPersonController.enabled = false;
            selector.enabled = false;

        }
        else if (isPaused == false)
        {
            Time.timeScale = 1;
            pauseCanvas.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            firstPersonController.enabled = true;
            selector.enabled = true;
        }
    }
}
