using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace PlayerStates
{
    public class MovementState : State
    {
        private float _moveDuration = 3;
        public Action OnPointMoved;
        
        public MovementState(Player player) : base(player)
        {
        }

        public override void Enter()
        {
            Debug.Log("EnterMovementStage");
            StartMove();
        }

        public override void Exit()
        {
            Debug.Log("ExitMovementStage");
        }

        private void StartMove()
        {
            Player.transform.DOMove(Player.transform.position + new Vector3(3, 0, 0), _moveDuration);
        }
    }
}
