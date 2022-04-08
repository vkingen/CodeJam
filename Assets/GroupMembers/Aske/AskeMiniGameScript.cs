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
    float delayTimePause;
    float delayTimeSpawn;

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
        Debug.Log(moleHit);
        if (moleHit == false)
        {
            Debug.Log(moleHit);
            Debug.Log("moleHit false");
            if (AccelerationZ > 2)
            {
<<<<<<< Updated upstream:Assets/GroupMembers/Aske/HammerScript.cs
                Mole.SetActive(false);
                Debug.Log("acceleration is 2");
                StartCoroutine(MolePoint());
                moleHit = true;
=======
                if (moleVisible == true)
                {
                    //audioSource.PlayOneShot(AudioClip audioClip, Float volumeScale);
                    Mole.SetActive(false);
                    //((StartCoroutine(MolePoint());
                    MolePoint();
                    moleHit = true;
                }
                else
                {
                    Debug.Log("Lose");
                }
>>>>>>> Stashed changes:Assets/GroupMembers/Aske/AskeMiniGameScript.cs
            }
        }
    }

    IEnumerator MolePoint()
    {
        Debug.Log("point");
        if (score < 10)
        {
            Debug.Log(score);
            score++;
            ScoreText.text = score + "/10";
            yield return new WaitForSeconds(delayTimePause);
            delayTimePause = Random.Range(1, 3);
            moleHit = false;
            Debug.Log(moleHit);
            SpawnMole();

        }    

        //else
        //{
            
        //}
    }

    public void SpawnMole()
    {
        Mole.transform.position = SpawnPoint[Random.Range(0, SpawnPoint.Length)].transform.position;
        Mole.SetActive(true);
        StartCoroutine(SwitchMole()); 
    }

    IEnumerator SwitchMole()
    {
        while (moleHit == false)
        {
            delayTimeSpawn = Random.Range(2, 4);
            yield return new WaitForSeconds(delayTimeSpawn);
            Mole.SetActive(false);
            delayTimeSpawn = Random.Range(0, 3);
            yield return new WaitForSeconds(delayTimeSpawn);
            Mole.SetActive(true);
        }
    }
}
