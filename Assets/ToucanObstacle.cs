using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucanObstacle : MonoBehaviour
{
    public Vector3 direction;
    public string bird, pointTrigger;
    ToucanCharacterController _toucanCharacterController;

    private void Start()
    {
        _toucanCharacterController = FindObjectOfType<ToucanCharacterController>();
    }

    private void FixedUpdate()
    {
        transform.position += direction;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == pointTrigger)
        {
            _toucanCharacterController.AddPoint();
        }
    }
}
