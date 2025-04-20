using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}

public class Spawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    
}