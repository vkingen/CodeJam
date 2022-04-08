using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{ 
    public static MainSceneManager instance;

    //[SerializeField] int currentSceneIndex;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
         }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene(int index)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index); //'1' is replaced by index if different minigames for different roles
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
