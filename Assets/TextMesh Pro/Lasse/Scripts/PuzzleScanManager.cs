using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScanManager : MonoBehaviour
{
    public GameObject[] imageTargets;

    private void Start()
    {
        foreach (GameObject i in imageTargets)
        {
            i.SetActive(false);
        }
        imageTargets[RoleManager.instance.role].SetActive(true);
    }
}
