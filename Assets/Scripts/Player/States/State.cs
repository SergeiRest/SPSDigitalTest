using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates
{
    public abstract class State
    {
        private Player _player;

        public Player Player => _player;

        public State(Player player)
        {
            _player = player;
            Enter();
        }
        
        public abstract void Enter();
        public abstract void Exit();
    }
}
