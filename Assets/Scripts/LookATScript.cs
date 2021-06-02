using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class LookATScript : MonoBehaviour
    {
        public Transform target;

        public void Update()
        {
            transform.LookAt(target);
        }
    }
}
