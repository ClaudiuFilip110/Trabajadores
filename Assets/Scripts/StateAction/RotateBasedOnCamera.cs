using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
namespace SA
{

    [CreateAssetMenu(menuName = "Actions/StateAction/Rotate Based On Camera Orientation")]
    public class RotateBasedOnCamera : StateActions
    {
        public TransformVariable cameraTransform;
        public float speed = 8;
        public int cv = 0;
        public override void Execute(StateManager states)
        {

            

                if (cameraTransform.value == null )
                {
                    return;
                }
                float h = states.movmentVariables.horizontal;
                float v = states.movmentVariables.vertical;
                Vector3 targetDir = cameraTransform.value.forward * v;
                targetDir += cameraTransform.value.right * h;
                targetDir.Normalize();
                targetDir.y = 0;
                if (targetDir == Vector3.zero)
                    targetDir = states.mTransform.forward;
                Quaternion tr = Quaternion.LookRotation(targetDir);
                Quaternion targetRotation = Quaternion.Slerp(states.mTransform.rotation, tr, states.delta * states.movmentVariables.moveAmount * speed);
                states.mTransform.rotation = targetRotation;
            
        }

    }
}