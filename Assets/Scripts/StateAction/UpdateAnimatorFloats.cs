using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/State Actions/UpdateAnimatorFloats")]
    public class UpdateAnimatorFloats : StateActions
    {
        public override void Execute(StateManager states)
        {
            states.anim.SetFloat("vertical", states.movmentVariables.moveAmount, 0.2f, states.delta);
        }
    }

}
