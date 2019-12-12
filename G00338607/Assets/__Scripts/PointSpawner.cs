using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    // get a list of spawn points
    // randomly select one to get the position at which to start the enemy
    [SerializeField]
    private float spawnDelay = 1.0f;

    [SerializeField]
    private float spawnInterval = 0.5f;

    [SerializeField]
    private Enemy enemyPrefab;

    private IList<SpawnPoint> spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GetComponentsInChildren<SpawnPoint>();
        SpawnRepeating();
    }

    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnInterval);
    }

    private void Spawn()
    {
        var randomIndex = UnityEngine.Random.Range(0, spawnPoints.Count);
        var currPoint = spawnPoints[randomIndex];
        var enemy = Instantiate(enemyPrefab);
        enemy.transform.position = currPoint.transform.position;
    }

}

