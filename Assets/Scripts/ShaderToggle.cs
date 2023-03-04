using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderToggle : MonoBehaviour
{
    private Picturesque.Darkbringer.DarkbringerEffect dui;
    [SerializeField] private Camera mainCam;
    [SerializeField] private Toggle shaderToggleBox;
    public static bool shaderOn = true;
    void Start()
    {
        dui = mainCam.GetComponent<Picturesque.Darkbringer.DarkbringerEffect>();
        if (shaderOn == true)
        {
            dui.enabled = true;
            shaderToggleBox.isOn = true;
        }
        else
        {
            dui.enabled = false;
            shaderToggleBox.isOn = false;
        }
    }

public void FlipBool()
    {
        shaderOn = !shaderOn;
    }

}
