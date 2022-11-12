using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject frypan;
    int second;

    void FixedUpdate()
    {
        second = Random.Range(3, 7);
        Invoke("SpawnPlay", second);
    }

    void SpawnPlay()
    {
        Instantiate(frypan, transform.position);
    }
}
