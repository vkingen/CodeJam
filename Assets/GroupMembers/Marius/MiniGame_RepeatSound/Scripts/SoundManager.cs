﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;

    [SerializeField] private AudioSource _soundOne,_soundTwo,soundThree;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }
}
