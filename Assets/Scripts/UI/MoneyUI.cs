using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

namespace MB
{
    public class MoneyUI : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text moneyTMP;

        public void SetMoney(int amount)
        {
            moneyTMP.text = amount + " $";
        }
    }
}