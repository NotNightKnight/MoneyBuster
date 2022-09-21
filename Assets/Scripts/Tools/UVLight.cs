using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MB
{
    public class UVLight : MonoBehaviour
    {
        [SerializeField]
        private ObjMover ObjMover;

        [SerializeField]
        private Transform startPos;

        [SerializeField]
        private GameObject moneyUV;

        [SerializeField]
        private GameObject lensMag;

        private void Start()
        {
            moneyUV.SetActive(false);
        }

        private void OnMouseDown()
        {
            ObjMover.AscendObj("UVLight");

            moneyUV.SetActive(true);

            lensMag.SetActive(false);
        }

        private void OnMouseDrag()
        {
            ObjMover.MoveObj("UVLight");
        }

        private void OnMouseUp()
        {
            transform.DOMove(startPos.position, 1.5f);

            moneyUV.SetActive(false);

            lensMag.SetActive(true);
        }
    }
}