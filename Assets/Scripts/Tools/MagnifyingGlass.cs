using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MB
{
    public class MagnifyingGlass : MonoBehaviour
    {
        [SerializeField]
        private ObjMover objMover;

        [SerializeField]
        private Transform startPos;

        [SerializeField]
        private GameObject moneyDoodle;

        [SerializeField]
        private GameObject lensUV;

        private void Start()
        {
            moneyDoodle.SetActive(false);
        }

        private void OnMouseDown()
        {
            objMover.AscendObj("magnifyingGlass");

            moneyDoodle.SetActive(true);

            lensUV.SetActive(false);
        }

        private void OnMouseDrag()
        {
            objMover.MoveObj("magnifyingGlass");
        }

        private void OnMouseUp()
        {
            transform.DOMove(startPos.position, 1.5f);

            moneyDoodle.SetActive(false);

            lensUV.SetActive(true);
        }
    }
}