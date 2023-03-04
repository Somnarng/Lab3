using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private bool isPaused = false;

    [SerializeField] private StarterAssets.FirstPersonController firstPersonController;
    [SerializeField] private PixelCrushers.DialogueSystem.Wrappers.Selector selector;

    private void Start()
    {
        pauseCanvas.SetActive(false);
        firstPersonController = FindObjectOfType<StarterAssets.FirstPersonController>();
        selector = FindObjectOfType<PixelCrushers.DialogueSystem.Wrappers.Selector>();
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
            pauseCanvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            firstPersonController.enabled = false;
            selector.enabled = false;

        }
        else if (isPaused == false)
        {
            Time.timeScale = 1;
            pauseCanvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            firstPersonController.enabled = true;
            selector.enabled = true;
        }
    }
}
