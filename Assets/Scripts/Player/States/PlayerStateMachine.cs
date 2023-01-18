using System;
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
            StageModel.OnStepComplete += EnterAttackState;
        }
        

        public void EnterAttackState()
        {
            CheckState();
            _currentState = new AttackState(_player);
        }

        public void EnterMovementState()
        {
            CheckState();
            _currentState = new MovementState(_player);
        }

        public void CheckState()
        {
            if (_currentState != null)
            {
                _currentState.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
