﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RufusPoint : MonoBehaviour
{
    public Text MyText;
    private int score;

    public TMP_Text pointText;
 
 
    // Use this for initialization
    void Start () {
   
        MyText.text = "";
 
    }
 
    // Update is called once per frame
    void Update () {
   
        MyText.text = "" + score;
 
    }
 
 
    void OnTriggerEnter(Collider coll) {
 
        score = score + 1;
 
    }
 
 
}
