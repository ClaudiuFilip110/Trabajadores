using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
namespace SA
{[CreateAssetMenu(menuName ="Actions/Mono Actions/Input Manager")]
    public class InputManager : Action
    {
        public FloatVariable horizontal, vertical;
        public StateManegerVariable playerStates;
        public ActionBatch inputUpdateBatch;
        public override void Execute()
        {
            inputUpdateBatch.Execute();
           if(playerStates.value!=null)
            {
                playerStates.value.movmentVariables.horizontal = horizontal.value;
                playerStates.value.movmentVariables.vertical = vertical.value;
                float moveAmount=Mathf.Clamp01((Mathf.Abs(horizontal.value)+Mathf.Abs(vertical.value)));
                playerStates.value.movmentVariables.moveAmount = moveAmount;
            }
        }
    }
}
