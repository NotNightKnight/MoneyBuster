using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class GameManager : MonoBehaviour
    {
        private int money = 0;

        public void GainMoney(int amount)
        {
            money += amount;
        }
    }
}