using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHole : MonoBehaviour
{
    public string ball = "Ball";


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ball)
        {
            Debug.Log("WIN!");

        }
    }

}
