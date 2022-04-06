using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;

    public void StartSound()
    {
        SoundManager.instance.Sound(_audioClip);
    }
}
