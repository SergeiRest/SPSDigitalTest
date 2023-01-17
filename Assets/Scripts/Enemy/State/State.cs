using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public abstract class State : IStateChanger
    {
        public Action<State> StateChanged;
        public State(Player player)
        {
        }

        public abstract void Enter();
        public abstract void Exit();
        
        public void Change()
        {
            StateChanged?.Invoke(this);
        }
    }
}
