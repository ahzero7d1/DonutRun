﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject frypan;
    public float TimeBetweenSpawn;
    float SpawnTime;

    void FixedUpdate()
    {
        RandomTime();
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }

    }

    void Spawn()
    {
        Instantiate(frypan, transform.position, Quaternion.Euler(new Vector3(0,0,-90)));
    }

    void RandomTime()
    {
        TimeBetweenSpawn = Random.Range(6, 9);
    }

}
