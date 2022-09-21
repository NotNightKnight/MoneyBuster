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
        private GameObject lens;

        private void OnMouseDown()
        {
            objMover.AscendObj("magnifyingGlass");

            //lens.SetActive(true);
        }

        private void OnMouseDrag()
        {
            objMover.MoveObj("magnifyingGlass");
        }

        private void OnMouseUp()
        {
            transform.DOMove(startPos.position, 2f);

            //lens.SetActive(false);
        }
    }
}