using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;

namespace SA
{[CreateAssetMenu(menuName ="Actions/Mono Actions/Follow Transform ")]
    public class FollowTransform : Action
    {
        public TransformVariable targetTransform , curentTransform;

        public FloatVariable delta;
        public float speed = 9;

        public override void Execute()
        { 
      
            if (targetTransform.value == null)
                return;
            if (curentTransform == null)
                return;
            Vector3 targetPosition = Vector3.Lerp(curentTransform.value.position, targetTransform.value.position,delta.value * speed);
            curentTransform.value.position = targetPosition;

        }
    }
}
