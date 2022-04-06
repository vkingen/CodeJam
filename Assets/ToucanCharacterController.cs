using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucanCharacterController : MonoBehaviour
{
    Rigidbody _rigidbody;

    float _acceleration;
    public float speed;
    [SerializeField]
    private Vector3 newGravity;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Physics.gravity = newGravity;
    }

    private void FixedUpdate()
    {
        _acceleration = Input.acceleration.y;
        _rigidbody.AddForce(transform.up * _acceleration * speed);
        Debug.Log(_acceleration);
    }
}
