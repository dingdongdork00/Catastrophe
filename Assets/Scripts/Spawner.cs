using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;
    public float spawnDistance;
    private float timeSinceLastSpawn;


    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnRate)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0;
        }

        
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = Random.insideUnitSphere.normalized * spawnDistance;
        spawnPos += (Vector2)transform.position;

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }

}