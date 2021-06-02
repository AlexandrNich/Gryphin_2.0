using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NodeSystem
{
    public class JointDevice : Device
    {
        public InputSystem InputSystem { get; private set; }

        [Range(1000, 50000)]
        [SerializeField] private float motorForce = 5000;
        [SerializeField] private float maxSpeed = 100.0f;

        private HingeJoint[] joints;

        public override void Work(float inputSignal)
        {
            foreach (var joint in joints)
            {
                var motor = joint.motor;
                motor.targetVelocity = inputSignal * maxSpeed;
                joint.motor = motor;
            }
        }

        private void Start()
        {
            joints = GetComponentsInChildren<HingeJoint>();
            foreach (var joint in joints)
            {
                joint.useMotor = true;
                var motor = joint.motor;
                motor.force = motorForce;
                joint.motor = motor;                
            }
            InputSystem = GetComponent<InputSystem>();
        }

        private void Update()
        {
            Work(InputSystem.ComputeSignal());
        }

    }
}
