using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public abstract class State : IStateChanger
    {
        protected Player player;
        protected Enemy enemy;
        
        public Action<State> StateChanged;
        public State(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public abstract void Enter();
        public abstract void Exit();
        
        public void Change(State state)
        {
            StateChanged?.Invoke(state);
        }
    }
}
