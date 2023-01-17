using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacteristic : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _health;

    public Action<int> OnDamageTaken;
    public Action<int, int> OnHealthLeft;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        OnDamageTaken?.Invoke(damage);
        OnHealthLeft?.Invoke(_maxHealth, _health);
    }
}
