using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateMachine
    {
        private Player _player;
        private State _currentState;

        public PlayerStateMachine(Player player)
        {
            _player = player;
            StageModel.OnStageStarted += EnterMovementState;
        }
        

        public void EnterAttackState()
        {
            _currentState = new AttackState(_player);
        }

        public void EnterMovementState()
        {
            _currentState = new MovementState(_player);
        }
    }
}
