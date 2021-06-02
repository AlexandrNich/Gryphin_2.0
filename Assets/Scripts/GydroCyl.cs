using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NodeSystem
{
    public class GydroCylRotator : Device
    {
        public float turnSpeed = 10f;

        public override void Work(float inputSignal)
        {
            transform.Rotate(Vector3.right, inputSignal * Time.deltaTime);
        }
    }
}
