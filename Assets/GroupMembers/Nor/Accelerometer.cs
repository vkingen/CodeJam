using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    //The rigidbody for the game object
    private Rigidbody rigid;

    public bool isFlat = true;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 tilt = Input.acceleration;
        tilt.y = 0;

        //makes sure that when it is flat the tilt points downwards
        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0)*tilt;

        //Moves the rigidbody through how the phone is tiltid
        rigid.AddForce(tilt);

        
    }
}
