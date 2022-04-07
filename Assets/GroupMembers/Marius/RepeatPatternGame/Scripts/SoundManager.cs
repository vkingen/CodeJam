using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioSource _sound;

    private void Awake()
    {
        instance = this;
    }
    
    public void Sound(AudioClip clip)
    {
        _sound.PlayOneShot(clip);
    }
}
