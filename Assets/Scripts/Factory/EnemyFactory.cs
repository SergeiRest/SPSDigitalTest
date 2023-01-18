using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private Transform _point;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private int _minEnemyOnStage;
    [SerializeField] private int _maxEnemyOnStage;
    
    private EnemiesContainer _enemiesContainer;
    private Player _player;

    public void Init(EnemiesContainer container, Player player)
    {
        _player = player;
        _enemiesContainer = container;
        StageModel.OnStepComplete += () => StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        int enemyCount = 0;
        int enemiesToSpawn = Random.Range(_minEnemyOnStage, _maxEnemyOnStage);
        _enemiesContainer.SetEnemiesCountToCompleteStage(enemiesToSpawn);
        while (enemyCount < enemiesToSpawn)
        {
            yield return new WaitForSecondsRealtime(_spawnInterval);
            Enemy enemy = Instantiate(_enemyPrefab, transform);
            enemy.transform.position = _point.position;
            enemy.Init(_player);
            enemy.OnEnemyDead += _enemiesContainer.RemoveEnemy;
            enemyCount++;
            _enemiesContainer.AddEnemy(enemy);
        }
    }
}
