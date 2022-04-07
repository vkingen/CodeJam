using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour


{
    // Start is called before the first frame update
    public float moveSpeed = 600f;
    float movement = 0f;
    public int points = 5;
    public TMP_Text pointText;
    // Update is called once per frame

    private void Start() {
        pointText.text = points.ToString();
    }
    void Update() 
    {
        movement = Input.GetAxisRaw("Horizontal");
          
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "PointTrigger")
        {
            points--; // points-- means that it takes 1 from the original value.
            pointText.text = points.ToString();
            if(points <= 0)
            {
                Debug.Log("WIN and change scene.s");
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
