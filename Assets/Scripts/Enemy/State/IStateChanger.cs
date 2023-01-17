using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyState
{
    public interface IStateChanger
    {
        void Change(State state);
    }
}
