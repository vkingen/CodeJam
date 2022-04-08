using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public int index = 1;
    public void StartGame()
    {
        //mainSceneManager.LoadNextScene(index);
        MainSceneManager.instance.LoadNextScene(index);
    }
}
