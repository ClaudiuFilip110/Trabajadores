using UnityEngine;
using System.Collections;
namespace SA {
    public class OnEnable_AssignStateManager : MonoBehaviour
    {
        public StateManegerVariable targetVariable;
        private void OnEnable()
        {
            targetVariable.value = GetComponent<StateManager>();
            Destroy(this);

        }
    }
}