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


        private GoldClon goldClon;
        private ArabaSatinAl _market;




        private void Start()
        {
            InvokeRepeating("clon", 0, spawnDuration);
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

        

      

        public class GoldSpawner : MonoBehaviour
        {
            public Gold goldRes;
            public Vector3 offset = new Vector3(2, 0, 2);

            public void SpawnGold(int count)
            {
                for (int i = 0; i < count; i++)
                {
                    var pos = transform.position + (offset * i);
                    // 1. pos = (0,0,0)
                    //2. pos =  (2,0,2)
                    //3.pos = (4,0,4)
                    Instantiate(goldRes, pos, Quaternion.identity);
                }
            }

        }

        public class Gold : MonoBehaviour
        {
            public int score;
        }
    }
}


