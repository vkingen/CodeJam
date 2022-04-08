using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HammerScript : MonoBehaviour
{ 
    public TMP_Text ScoreText;
    public int score = 0;
    public float AccelerationZ;
    bool moleHit = false;
    bool moleVisible = false;
    //float delayTimePause;
    float delayTimeSpawn;
    public GameObject bonk;

    public GameObject Mole;
    public Transform[] SpawnPoint;

    public int nextSceneIndex;
    AudioSource audioData;

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
                    audioSource.PlayOneShot(AudioClip audioClip, Float volumeScale);
                    Mole.SetActive(false);
                    //((StartCoroutine(MolePoint());
                    MolePoint();
                    moleHit = true;
                }
                else
                {
                    Debug.Log("Lose");
                }
            }
        }
    }

    //IEnumerator MolePoint()
    void MolePoint()
    {
        score++;
        ScoreText.text = score + "/10";
        if (score < 10)
        {
            //yield return new WaitForSeconds(delayTimePause);
            //delayTimePause = Random.Range(1, 3);
            moleHit = false;
            SpawnMole();
        }

        else
        {
            Debug.Log("Win");
            MainSceneManager.instance.LoadNextScene(nextSceneIndex);
        }
    }

    public void SpawnMole()
    {
        Mole.transform.position = SpawnPoint[Random.Range(0, SpawnPoint.Length)].transform.position;
        StartCoroutine(SwitchMole());
        Mole.SetActive(true); 
    }

    IEnumerator SwitchMole()
    {
        while (moleHit == false)
        {
            delayTimeSpawn = Random.Range(2, 4);
            yield return new WaitForSeconds(delayTimeSpawn);
            Mole.SetActive(false);
            moleVisible = false;
            moleHit = true;

            delayTimeSpawn = 3;
            yield return new WaitForSeconds(delayTimeSpawn);

            delayTimeSpawn = Random.Range(0, 3);
            yield return new WaitForSeconds(delayTimeSpawn);
            Mole.SetActive(true);
            moleVisible = true;
            moleHit = false;
        }
    }
}
