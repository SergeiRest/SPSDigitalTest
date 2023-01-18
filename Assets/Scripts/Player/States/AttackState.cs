using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates
{
    public class AttackState : State
    {
        public AttackState(Player player) : base(player)
        {
        }

        public override void Enter()
        {
            Debug.Log("EnterAttackStage");
            Player.Gun.StartShooting();
        }

        public override void Exit()
        {
            Player.Gun.StopShooting();
            Debug.Log("ExitAttack");
        }
    }
}
