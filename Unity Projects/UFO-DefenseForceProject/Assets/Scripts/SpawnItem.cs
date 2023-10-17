using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnItem : MonoBehaviour
{
    public GameObject[] itemPrefabs; // array for items

    // x-axis spawn range and z-axis spawn position
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    // delays spawn by 5 seconds and then spawns at an interval of 8 seconds
    private float spawnInterval = 8f;
    private float startDelay = 5f;

    void Start()
    {
        // repeatedly calls SpawnRandomItem method using provided variables
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }
    
    void SpawnRandomItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // generates random spawn position w/ provided variables
        int itemIndex = Random.Range(0, itemPrefabs.Length); // picks a random item from array
        Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation); // spawns an indexed item from array @ a random location on the x-axis
    }
}
