﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class  StateManager : MonoBehaviour
    {
        public float health;
        
        public State currentState;

        public MovmentVariables movmentVariables;
        [HideInInspector]
        public float delta;
        [HideInInspector]
        public Transform mTransform;
        [HideInInspector]
        public new Rigidbody rigidbody;
        [HideInInspector]
        public Animator anim;

        private void Start()
        {
            mTransform = this.transform;
            rigidbody = GetComponent<Rigidbody>();
            anim = GetComponentInChildren<Animator>();
        }
        private void FixedUpdate()
        {
            delta = Time.fixedDeltaTime;
            if (currentState != null)
            {
                currentState.FixedTick(this);
            }

        }
        private void Update()
        {
            delta = Time.deltaTime;
            if(currentState != null)
            {
                currentState.Tick(this);
            }
        }
    }
}
