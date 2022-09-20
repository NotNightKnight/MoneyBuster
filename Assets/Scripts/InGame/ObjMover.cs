using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB
{
    public class ObjMover : MonoBehaviour
    {
        [SerializeField]
        private Transform moneyObj;

        [SerializeField]
        private Transform UVLightObj;

        [SerializeField]
        private Transform magnifyingGlassObj;

        [SerializeField]
        private float dragSpeed;

        [SerializeField]
        private float ascendObj;

        public void AscendObj(string objName)
        {
            switch(objName)
            {
                case "money":
                    Ascend(moneyObj);
                    break;
            }
        }
        private void Ascend(Transform obj)
        {
            obj.position += new Vector3(0, ascendObj, 0);
        }

        public void MoveObj(string objName)
        {
            switch(objName)
            {
                case "money":
                    Move(moneyObj);
                    break;
                case "UVLight":
                    Move(UVLightObj);
                    break;
                case "magnifyingGlass":
                    Move(magnifyingGlassObj);
                    break;
            }
        }
        private void Move(Transform obj)
        {
            var Xscale = Input.GetAxis("Mouse X");
            var Yscale = Input.GetAxis("Mouse Y");

            obj.position += Xscale * dragSpeed * Time.deltaTime * Vector3.right;

            obj.position += Yscale * dragSpeed * Time.deltaTime * Vector3.forward;
        }
    }
}