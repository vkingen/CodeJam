using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerClue : MonoBehaviour
{
    public float thresh = 5;
    public TMPro.TMP_Text text;
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
        }

        if (text)
            text.text = "Acceleration " + Input.acceleration.ToString();
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