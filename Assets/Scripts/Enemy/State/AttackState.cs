using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace EnemyState
{
    public class AttackState : State
    {
        public AttackState(Player player, Enemy enemy) : base(player, enemy)
        {
        }

        public override void Enter()
        {
            Debug.Log(enemy);
            Debug.Log("AttackState");
            Attack();
        }

        public override void Exit()
        {
            Debug.Log("Stop attack");
        }

        private void Attack()
        {
            enemy.Fight.Attack(player);
        }
    }
}
