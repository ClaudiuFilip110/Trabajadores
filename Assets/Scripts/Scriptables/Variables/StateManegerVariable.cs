using UnityEngine;
using System.Collections;
namespace SA
{[CreateAssetMenu(menuName ="Variables/StateManager")]
    public class StateManegerVariable : ScriptableObject
    {
        public StateManager value;
        public void Set(StateManager s)
        {
            value = s;
        }

    }
}