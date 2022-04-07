using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToucanCharacterController : MonoBehaviour
{
    Rigidbody _rigidbody;

    float _acceleration;
    public float speed;
    [SerializeField]
    private Vector3 newGravity;
    public int totalPoints = 0;
    public TMP_Text pointText;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Physics.gravity = newGravity;
        pointText.text = totalPoints.ToString();
    }

    private void FixedUpdate()
    {
        _acceleration = Input.acceleration.y;
        _rigidbody.AddForce(transform.up * _acceleration * speed);
    }
    public void AddPoint()
    {
        totalPoints++;
        pointText.text = totalPoints.ToString();
        if (totalPoints >= 0)
        {
            Debug.Log("You Win");
        }
    }
}
