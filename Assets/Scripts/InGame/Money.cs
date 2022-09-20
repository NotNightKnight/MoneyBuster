using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class Money : MonoBehaviour
    {
        [SerializeField]
        private ObjMover ObjMover;

        [SerializeField]
        private Rigidbody myRigidbody;

        [SerializeField]
        private Transform startPos;

        private void OnMouseDown()
        {
            ObjMover.AscendObj("money");
            SetGravity(false);
        }

        private void OnMouseDrag()
        {
            ObjMover.MoveObj("money");    
        }

        private void OnMouseUp()
        {
            SetGravity(true);
        }

        public void GoToTable()
        {
            SetRigidbodyFalse();

            transform.DOMove(startPos.position, 1f);

            Invoke(nameof(SetRigidbodyTrue), 1.1f);
        }

        private void SetGravity(bool state)
        {
            myRigidbody.useGravity = state;
        }

        private void SetRigidbodyTrue()
        {
            myRigidbody.detectCollisions = true;
            myRigidbody.useGravity = true;
        }
        private void SetRigidbodyFalse()
        {
            myRigidbody.detectCollisions = false;
            myRigidbody.useGravity = false;
        }
    }
}