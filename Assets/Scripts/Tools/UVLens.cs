using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class UVLens : MonoBehaviour
    {
        [SerializeField]
        private Transform moneyUV, moneyNormal;

        private void Update()
        {
            moneyUV.position = moneyNormal.position * 2 - transform.position;
        }
    }
}