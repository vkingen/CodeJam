using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ubstacles : MonoBehaviour
{
    public string ball = "Ball";
    //method that detects collider //Slå the lige op
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ball)
        {
            Application.LoadLevel(Application.loadedLevel);

        }
    }
}
