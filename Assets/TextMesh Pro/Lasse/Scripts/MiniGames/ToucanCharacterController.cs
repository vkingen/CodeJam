using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
public class ToucanCharacterController : MonoBehaviour
{
    Rigidbody _rigidbody;

    float _acceleration;
    public float speed;
    [SerializeField]
    private Vector3 newGravity;
    public int totalPoints = 0;
    public TMP_Text pointText;
    ObstacleSpawner obstacleSpawner;

    public GameObject tutorial_Panel;
    bool gameHasStarted = false;
    AudioSource audioSource;
    //Acc acc;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
        _rigidbody = GetComponent<Rigidbody>();
        Physics.gravity = newGravity;
        pointText.text = "";
        //acc = new Acc();
        //InputSystem.EnableDevice(LinearAccelerationSensor.current);
    }

    public void StartGame()
    {
        tutorial_Panel.SetActive(false);
        gameHasStarted = true;
        obstacleSpawner.SendWaves();
        pointText.text = totalPoints.ToString();
    }

    private void FixedUpdate()
    {
        //Vector3 test = acc.GetAcc.AccData.ReadValue<Vector3>();
        //_acceleration = test.y;
        //Debug.Log(test);
        if(gameHasStarted)
        {
            _acceleration = Input.acceleration.y;
            _rigidbody.AddForce(transform.up * _acceleration * speed);
        }
        
    }
    public void AddPoint()
    {
        totalPoints++;
        audioSource.Play();
        pointText.text = totalPoints.ToString();
        if (totalPoints >= 0)
        {
            MainSceneManager.instance.LoadNextScene(1);
            Debug.Log("You Win");
        }
    }
}
