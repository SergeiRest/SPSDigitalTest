using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public class StateContoller
    {
        private State _currentState;

        public void Init(Player player, Transform transform)
        {
            _currentState = new MovementState(player, transform);
            _currentState.Enter();
            _currentState.StateChanged += ChangeState;
        }

        public void ChangeState(State newState)
        {
            _currentState.Exit();
            _currentState = newState;
            _currentState.Enter();
        }
    }
}
