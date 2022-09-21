using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class MagGlass : MonoBehaviour
    {
        [SerializeField]
        private Transform bigMoney, smallMoney;

        private void Update()
        {
            bigMoney.position = smallMoney.position * 2 - transform.position;
        }
    }
}