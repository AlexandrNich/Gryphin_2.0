using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NodeSystem
{
    public class KeyboardInput : InputSystem
    {
        public KeyCode positiveSignal;
        public KeyCode negativeSignal;
       
        [SerializeField] private float lerpMultiply = 1.0f;
        private float currentSignal = 0.0f;
        private const float positiveValue = 1.0f;
        private const float negativeValue = -1.0f;


        private void Start()
        {
        }
        public override float ComputeSignal()
        {
            if (Input.GetKey(positiveSignal))
            {
                if (Mathf.Abs(currentSignal - positiveValue) > .1f)
                {
                    currentSignal = Mathf.Lerp(currentSignal, positiveValue, Time.deltaTime * lerpMultiply);
                }
                else
                {
                    currentSignal = positiveValue;
                }
                return currentSignal;
            }
            else if (Input.GetKey(negativeSignal))
            {
                if (Mathf.Abs(currentSignal - negativeValue) > .1f)
                {
                    currentSignal = Mathf.Lerp(currentSignal, negativeValue, Time.deltaTime * lerpMultiply);
                }
                else
                {
                    currentSignal = negativeValue;
                }
                return currentSignal;
            }
            else
            {
                if (Mathf.Abs(currentSignal - 0) > .1f)
                {
                    currentSignal = Mathf.Lerp(currentSignal, 0, Time.deltaTime * lerpMultiply);
                }
                else
                {
                    currentSignal = 0;
                }
                return currentSignal;
            }
        }
    }
}
