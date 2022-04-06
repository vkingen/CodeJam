using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleMovementScript : MonoBehaviour
{
    public GameObject Mole;
    public Transform[] spawnPoint;
    public Text PointsText;
    public int points=0;
    void Start()
    {
        SpawnMole();
    }
    
    void Update()
    {
        
    }

    void SpawnMole()
    {
        Mole.transform.position = spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position;
    }

    void MolePoint()
    {
        PointsText.text = points+"/10";
    }
}
