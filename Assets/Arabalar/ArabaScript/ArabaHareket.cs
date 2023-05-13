using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarGame
{
    public class ArabaHareket : MonoBehaviour
    {
        public WheelCollider onsoltekerlek, onsagtekerlek, arkasoltekerlek, arkasagtekerlek;
        public float motorhizi, donmehizi;
        public Joystick tus;
        public float spawnDuration = 4.0f;
        public bool canMove;
        public GameObject gold;
        public Gold goldRes;

        private GoldClon goldClon;
        private ArabaSatinAl _market;
        private object GoldSpawner;

        private void Start()
        {
            InvokeRepeating("Clon", 0, spawnDuration);
            _market = GameObject.FindGameObjectWithTag("Para").GetComponent<ArabaSatinAl>();
        }

        void Update()
        {
            if(canMove)
            {
                arkasagtekerlek.motorTorque = motorhizi * -tus.Vertical;
                arkasoltekerlek.motorTorque = motorhizi * -tus.Vertical;
                //saða sola dönme
                onsagtekerlek.steerAngle = donmehizi * tus.Horizontal;
                onsoltekerlek.steerAngle = donmehizi * tus.Horizontal;

            }

            

        }
         public void Clon()
         {
            goldClon = gold.GetComponent<GoldClon>();

         }

        public void Goldolustur()
        {
            GoldSpawner = goldRes.GetComponent<GoldSpawner>();
        }





        public class Gold : MonoBehaviour
        {
            public int score;
        }
    }
}


