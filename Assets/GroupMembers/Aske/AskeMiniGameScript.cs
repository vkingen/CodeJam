using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AskeMiniGameScript : MonoBehaviour
{ 
    public TMP_Text ScoreText;
    public int score = 0;
    public float AccelerationZ;
    bool moleHit = false;
    float delayTimeVisible;
    float delayTimeNotVisible;
    bool moleVisible = false;

    public GameObject Mole;
    public Transform[] SpawnPoint;

    MoleScript MoleScript;
    // Start is called before the first frame update
    void Start()
    {
        SpawnMole();
    }

    // Update is called once per frame
    void Update()
    {
        AccelerationZ = Input.acceleration.z;
        if (moleHit == false)
        {
            if (AccelerationZ > 2)
            {
                if (moleVisible == true)
                {
                    moleHit = true;
                    Mole.SetActive(false);
                    MolePoint();
                }

                else
                {
                    Debug.Log("lose");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
        }
    }

    void MolePoint()
    {
        score++;
        ScoreText.text = score + "/10";
        Debug.Log("point");
        if (score < 10)
        {
            moleHit = false;
            SpawnMole();
        }    

        else
        {
            Debug.Log("win");
            MainSceneManager.instance.LoadNextScene(1); //change magic number
        }
    }

    public void SpawnMole()
    {
        Mole.transform.position = SpawnPoint[Random.Range(0, SpawnPoint.Length)].transform.position;
        Mole.SetActive(true);
        StartCoroutine(SwitchMole());
        Debug.Log("spawn");
    }

    IEnumerator SwitchMole()
    {
        while (moleHit == false)
        {
            delayTimeNotVisible = Random.Range(10, 10); //this comtrols the amount of time the mole is not visible
            yield return new WaitForSeconds(delayTimeNotVisible);
            Mole.SetActive(true);
            moleVisible = true;
            delayTimeVisible = Random.Range(2, 2); //this comtrols the amount of time the mole is visible
            yield return new WaitForSeconds(delayTimeVisible);
            Mole.SetActive(false);
            moleVisible = false;
        }
    }
}
