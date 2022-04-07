using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggleHandler : MonoBehaviour
{
    public GameObject background;
    
    public void mutedToggle()
    {
        Toggle toggle = GetComponent<Toggle>();
        background.SetActive(!toggle.isOn);
    }
}
