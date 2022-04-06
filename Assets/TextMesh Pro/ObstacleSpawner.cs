using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform[] spawnPosition;

    public float delayTime = 2f;

    private void Start()
    {
        StartCoroutine(SpawnObjectWithDelay());

    }

    IEnumerator SpawnObjectWithDelay()
    {
        int randomNum = Random.Range(0, spawnPosition.Length);
        GameObject clone = Instantiate(objectToSpawn, spawnPosition[randomNum].position, Quaternion.identity);
        //clone.GetComponent<Rigidbody>().AddForce(0, -600, 0);
        yield return new WaitForSeconds(delayTime);
        StartCoroutine(SpawnObjectWithDelay());
    }
}
