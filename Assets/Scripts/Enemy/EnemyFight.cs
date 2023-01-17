using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFight : MonoBehaviour
{
    [SerializeField] private float _attackCooldown;
    [SerializeField] private int damage;

    public void Attack(Player player)
    {
        StartCoroutine(AttackWithInterval(player));
    }

    private IEnumerator AttackWithInterval(Player player)
    {
        player.Character.TakeDamage(damage);
        yield return new WaitForSecondsRealtime(_attackCooldown);
        Attack(player);
    }
}
