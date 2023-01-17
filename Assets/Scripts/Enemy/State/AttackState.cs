using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace EnemyState
{
    public class AttackState : State
    {
        public AttackState(Player player) : base(player)
        {
        }

        public override void Enter()
        {
            Debug.Log("AttackState");
        }

        public override void Exit()
        {
            Debug.Log("Stop attack");
        }
    }
}
