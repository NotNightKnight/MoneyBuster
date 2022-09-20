using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class Ground : MonoBehaviour
    {
        [SerializeField]
        private Money money;

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.CompareTag("Money"))
            {
                money.GoToTable();
            }
        }
    }
}