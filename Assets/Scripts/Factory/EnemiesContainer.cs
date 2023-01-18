using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesContainer
{
    private List<Enemy> _enemies = new List<Enemy>();
    private int _killsCount = 0;
    private int _enemiesOnWave = 0;

    public void AddEnemy(Enemy enemy) => _enemies.Add(enemy);

    public void RemoveEnemy(Enemy enemy)
    {
        _enemies.Remove(enemy);
        _killsCount++;
        if (_killsCount >= _enemiesOnWave)
        {
            StageModel.OnStageStarted?.Invoke();
            _killsCount = 0;
        }
    }

    public Enemy GetNearestEnemy(Transform transform)
    {
        if (_enemies.Count <= 0)
            return null;
        
        Enemy nearEnemy = _enemies[0];
        Vector3 nearestDistance = _enemies[0].transform.position; 
        for (int i = 0; i < _enemies.Count; i++)
        {
            if ((transform.position - _enemies[i].transform.position).sqrMagnitude < (transform.position - nearestDistance).sqrMagnitude)
            {
                nearEnemy = _enemies[i];
                nearestDistance = _enemies[i].transform.position;
            }
        }

        return nearEnemy;
    }

    public void SetEnemiesCountToCompleteStage(int value)
    {
        _enemiesOnWave = value;
    }
}
