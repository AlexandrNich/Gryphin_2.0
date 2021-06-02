using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NodeSystem
{
    public abstract class InputSystem : MonoBehaviour
    {
        public abstract float ComputeSignal();
    }
}
