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
        public GameObject Gold;
        public Transform konum1, konum2, konum3;
        ArabaSatinAl market;


        private void Start()
        {
            InvokeRepeating("clon", 0, 4.0f);
        }

        void Update()
        {

            //ileri geri gitme
            arkasagtekerlek.motorTorque = motorhizi * -tus.Vertical;
            arkasoltekerlek.motorTorque = motorhizi * -tus.Vertical;
            //saða sola dönme
            onsagtekerlek.steerAngle = donmehizi * tus.Horizontal;
            onsoltekerlek.steerAngle = donmehizi * tus.Horizontal;


        }

        public void clon()
        {
            if(tus.Vertical > 0)
            {
                GameObject goldobje = Instantiate(Gold, konum1.transform.position, Quaternion.identity);
                GameObject goldobje2 = Instantiate(Gold, konum2.transform.position, Quaternion.identity);
                GameObject goldobje3 = Instantiate(Gold, konum3.transform.position, Quaternion.identity);
                Debug.Log("altýn objesi oluþturdu");


            }
            
        }

        public void OnTriggerEnter(Collider nesne)
        {
            if(nesne.gameObject.tag == "Gold")
            {
                market = GameObject.FindGameObjectWithTag("Para").GetComponent<ArabaSatinAl>();
                market.para += 100;
                Destroy(nesne.transform.gameObject);
            }
            
        }


    }
}


