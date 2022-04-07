using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    //public bool hasEnableCamera = false;
    public GameObject cluePanel, cameraPanel;

    private void Awake()
    {
        cameraPanel.SetActive(false);
    }

    public void OpenCameraPanel()
    {
        cameraPanel.SetActive(true);
        cluePanel.SetActive(false);
    }
    public void OpenCluePanel()
    {
        cameraPanel.SetActive(false);
        cluePanel.SetActive(true);
    }
}
