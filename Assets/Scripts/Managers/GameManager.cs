using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private MoneyUI moneyUI;

        [SerializeField]
        private CanvasGroup endLevelPanel;

        private int money = 0;

        public void EndLevel()
        {
            Time.timeScale = 0;
            endLevelPanel.alpha = 1;
            endLevelPanel.interactable = true;
            endLevelPanel.blocksRaycasts = true;
        }

        public void GainMoney(int amount)
        {
            money += amount;
            moneyUI.SetMoney(money);
        }
    }
}