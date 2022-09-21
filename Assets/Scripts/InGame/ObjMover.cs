using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        private float moneyAscend;

        [SerializeField]
        private float magGlassAscend;

        [SerializeField]
        private float UVLightAscend;

        //private Quaternion rotUV = new Quaternion(-90,205,0,0);
        //private Quaternion rotMag = new Quaternion(0, 205, 0, 0);

        public void AscendObj(string objName)
        {
            switch(objName)
            {
                case "money":
                    moneyObj.position += new Vector3(0, moneyAscend, 0);
                    break;
                case "magnifyingGlass":
                    magnifyingGlassObj.position += new Vector3(0, magGlassAscend, 0);
                    break;
                case "UVLight":
                    UVLightObj.position += new Vector3(0, UVLightAscend, 0);
                    break;
            }
        }
        //private void Ascend(Transform obj)
        //{
        //    obj.position += new Vector3(0, ascendObj, 0);
        //}

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