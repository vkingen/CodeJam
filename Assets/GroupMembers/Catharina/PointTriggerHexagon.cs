﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTriggerHexagon : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            // Add Points
        }
    }
}
