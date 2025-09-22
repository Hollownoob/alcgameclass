using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float StartDelay;
    public float SpawnInterval;
    public float xRange = 20.0f;
    public float yPos = -40.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        Vector3 Spawnpos = new Vector3(Random.Range(-xRange,xRange),0,0);
        int Balloonindex = Random.Range(0,balloonPrefabs.Length);
        Instantiate(balloonPrefabs[Balloonindex], Spawnpos, balloonPrefabs[Balloonindex].transform.rotation);
    }
}
