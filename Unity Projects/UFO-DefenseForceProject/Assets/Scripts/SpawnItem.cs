using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnItem : MonoBehaviour
{
    public GameObject[] itemPrefabs;

    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float spawnInterval = 8f;
    private float startDelay = 5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }
    
    void SpawnRandomItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int itemIndex = Random.Range(0, itemPrefabs.Length);
        Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation);
    }
}
