using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SA
{[CreateAssetMenu(menuName ="Action/StateAction/MovmentForward")]
    public class MovmentForward : StateActions
    {
        public float movementSpeed = 2;
        public override void Execute(StateManager states)
        {
           if(states.movmentVariables.moveAmount>0.1f)
            {
                states.rigidbody.drag = 0;
            }
           else
            {
                states.rigidbody.drag = 4;
            }
            Vector3 targetVelocity = states.mTransform.forward * states.movmentVariables.moveAmount * movementSpeed;
            targetVelocity.y = states.rigidbody.velocity.y;
            states.rigidbody.velocity = targetVelocity;
        }
    }
}
