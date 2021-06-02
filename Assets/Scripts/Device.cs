using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeSystem
{
    public abstract class Device : MonoBehaviour
    {
        public abstract void Work(float inputSignal);
    }
}
