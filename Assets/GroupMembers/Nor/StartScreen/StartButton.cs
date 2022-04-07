using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        //Loading to next scene. Finding the active scene and the build index and adding 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
