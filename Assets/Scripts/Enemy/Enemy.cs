using System.Collections;
using EnemyState;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyFight _fight;
    [SerializeField] private int _health;
    
    private StateContoller _stateContoller = new StateContoller();
    private EnemyCharacteristic _characteristic;
    private Player _target;

    public EnemyFight Fight => _fight;
    public EnemyCharacteristic Characteristic => _characteristic;

    public Action<Enemy> OnEnemyDead;

    public void Init(Player target)
    {
        _characteristic = new EnemyCharacteristic(_health);
        _characteristic.OnHealthOver += Destroy;
        StartCoroutine(StartMovement());
        _target = target;
    }

    private IEnumerator StartMovement()
    {
        yield return new WaitForSecondsRealtime(1f);
        _stateContoller.Init(_target, this);
    }

    private void Destroy()
    {
        OnEnemyDead?.Invoke(this);
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        OnEnemyDead = null;
        Characteristic.OnDamageTaken = null;
        Characteristic.OnHealthOver = null;
    }
}
