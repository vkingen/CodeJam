using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerClue : MonoBehaviour
{
    public float thresh = 5;

    public TMPro.TMP_Text accText;
    public TMPro.TMP_Text limitText;

    public int limit = 50;

    private bool _trigger = false;
    private int _threshCounter = 0;



    void Update()
    {
        AccelerometerData();
        EndGame();
    }


    public void AccelerometerData()
    {
        if (Input.acceleration.magnitude > thresh)
        {
                if (!_trigger)
            {
                _trigger = true;
                _threshCounter++;
                Debug.Log(_threshCounter);
            }
        }
        else if (_trigger)
        {
            _trigger = false;
            Debug.Log("false");
        }

        if (accText && limitText)
        {
            accText.text = "Acceleration\n" + Input.acceleration.ToString();
            limitText.text = _threshCounter + "/" + limit;
        }
            

    }

    public void EndGame()
    {
        if (_threshCounter == limit)
        {
            MainSceneManager.instance.LoadNextScene(2); // make variable instead of magic number
            Debug.Log("Won Game - move to next scene and get clue");
        }
    }
}