using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGSpawns : MonoBehaviour
{

    public GameObject SpawnedObject;
    public bool StopSpawn = false;
    public float SpawnTime;
    public float SpawnDelay;

    //public GameObject[] SpawnPoints;
    //int Randomint;

    void Start()
    {
        InvokeRepeating("SpawnObjects", SpawnTime, SpawnDelay);
    }

    public void SpawnObjects()
    {
        Instantiate(SpawnedObject, transform.position, transform.rotation);
        if (StopSpawn)
        {
            CancelInvoke("SpawnObjects");
        }
    }
}