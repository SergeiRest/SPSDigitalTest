using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public class MovementState : State
    {
        private EnemyMovement _enemyMovement;
        private Player _player;
        
        public MovementState(Player player, Transform transform) : base(player)
        {
            _enemyMovement = new EnemyMovement(player, transform);
            _player = player;
        }

        public override void Enter()
        {
            Debug.Log("MovementState");
            _enemyMovement.Move(TargetReached);
        }

        private void TargetReached()
        {
            StateChanged?.Invoke(new AttackState(_player));
        }

        public override void Exit()
        {
            _enemyMovement.Stop();
            Debug.Log("StopMovement");
        }
    }
}
