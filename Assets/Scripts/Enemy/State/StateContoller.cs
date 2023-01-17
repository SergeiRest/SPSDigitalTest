using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public class StateContoller
    {
        private State _currentState;

        public void Init(Player player, Enemy enemy)
        {
            _currentState = new MovementState(player, enemy);
            _currentState.Enter();
            _currentState.StateChanged += ChangeState;
        }

        public void ChangeState(State newState)
        {
            _currentState.Exit();
            _currentState.StateChanged = null;
            _currentState = newState;
            _currentState.Enter();
            _currentState.StateChanged += ChangeState;
        }
    }
}
