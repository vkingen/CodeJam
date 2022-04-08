using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{ 
    public static MainSceneManager instance;

    [SerializeField] int currentSceneIndex;

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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene(int index)
    {
        SceneManager.LoadScene(currentSceneIndex + 1); //'1' is replaced by index if different minigames for different roles
    }
}
