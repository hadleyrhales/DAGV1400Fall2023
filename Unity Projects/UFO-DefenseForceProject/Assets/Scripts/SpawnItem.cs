using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;
    public Transform itemSpawn;

    public float interval = 5;
    private float timer;
    
    // needs to spawn item
    // item moves down screen
    // when item collides with player it is recorded in inventory and destroyed
        // is destroyed on collision
        // needs to be recorded in variable "inventory"

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            Instantiate(item, itemSpawn.transform.position, item.transform.rotation);
            timer -= interval;
        }
    }
}
