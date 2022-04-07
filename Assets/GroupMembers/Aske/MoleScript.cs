using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    public GameObject Mole;
    public Transform[] SpawnPoint;
    void Start()
    {
        SpawnMole();
    }
    
    void Update()
    {
        
    }

    void SpawnMole()
    {
        Mole.transform.position = SpawnPoint[Random.Range(0, SpawnPoint.Length)].transform.position;
    }
}
