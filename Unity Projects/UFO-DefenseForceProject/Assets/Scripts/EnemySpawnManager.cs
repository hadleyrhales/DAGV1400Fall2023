using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // array for UFO ships
    
    // x-axis spawn range an z-axis spawn position
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    // delays spawn by 2 seconds and then spawns at an interval of 1.5 seconds
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        // repeatedly calls SpawnRandomUFO method using provided variables
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // generates random spawn position w/ provided variables
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); // picks a random UFO from array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); // spawns an indexed UFO from array @ a random location on the x-axis
    }
}
