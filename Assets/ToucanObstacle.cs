using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucanObstacle : MonoBehaviour
{
    public Vector3 direction;

    private void FixedUpdate()
    {
        transform.position += direction;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
