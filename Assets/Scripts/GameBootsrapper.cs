using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootsrapper : MonoBehaviour
{
    [SerializeField] private StagePresenter _stageView;
    [SerializeField] private Player _player;
    [SerializeField] private EnemyFactory _enemyFactory;
    
    private EnemiesContainer _enemiesContainer;

    private void Start()
    {
        _enemiesContainer = new EnemiesContainer();
        _player.Init(_enemiesContainer);
        _stageView.Init();
        _enemyFactory.Init(_enemiesContainer, _player);
    }
}
