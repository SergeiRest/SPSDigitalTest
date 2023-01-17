using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public class MovementState : State
    {
        private EnemyMovement _enemyMovement;

        public MovementState(Player player, Enemy enemy) : base(player, enemy)
        {
            _enemyMovement = new EnemyMovement(player, enemy.transform);
        }

        public override void Enter()
        {
            Debug.Log("MovementState");
            _enemyMovement.Move(TargetReached);
        }

        private void TargetReached()
        {
            Debug.Log(enemy);
            Change(new AttackState(player, enemy));
        }

        public override void Exit()
        {
            _enemyMovement.Stop();
            Debug.Log("StopMovement");
        }
    }
}
