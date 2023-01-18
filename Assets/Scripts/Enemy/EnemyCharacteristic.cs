using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacteristic
{
    private int _health;
    private int _maxHealth;

    public Action OnHealthOver;
    public Action<int> OnDamageTaken;
    public Action<float> HealthLeft;

    public EnemyCharacteristic(int health)
    {
        _health = health;
        _maxHealth = health;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        float healthPercent = (float) _health / (float) _maxHealth;
        OnDamageTaken?.Invoke(damage);
        HealthLeft?.Invoke(healthPercent);
        
        if (_health <= 0)
        {
            OnHealthOver?.Invoke();
        }
    }
}
