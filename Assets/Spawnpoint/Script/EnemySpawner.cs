﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyObject;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnThreshold = 2;

    private float _timer;

    private void Start()
    {
        SpawnEnemy();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnThreshold)
        {
            SpawnEnemy();
            _timer = 0;
        }
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        SpawnPoint spawnPoint = _spawnPoints[randomIndex];
        Vector3 SpawnPosition = spawnPoint.GetSpawnPosition();
        Instantiate(_enemyObject, SpawnPosition, Quaternion.identity);
    }
}
