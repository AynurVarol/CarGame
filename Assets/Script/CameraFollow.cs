using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CarGame
{
    public class CameraFollow : MonoBehaviour
    {
        public ArabaSatinAl arabaSatinAl;
        public Camera camera;
        public Transform target;
        public Vector3 offset;

        private void Start()
        {

            var target = arabaSatinAl.carSelector.SelectedCar;

            transform.position = target.transform.position + offset;

            Camera.main.transform.position = target.transform.position;
        }




    }
}
