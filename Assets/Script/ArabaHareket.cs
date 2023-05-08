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
        public GameObject gold;
        public Transform konum1, konum2, konum3;
        public float spawnDuration = 4.0f;
        public int diamondMoney = 100;



        private ArabaSatinAl _market;


        public const string diamond_tag = "Gold";

        private void Start()
        {
            InvokeRepeating("clon", 0, spawnDuration);
            _market = GameObject.FindGameObjectWithTag("Para").GetComponent<ArabaSatinAl>();
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
            if (tus.Vertical > 0)
            {
                GameObject goldobje = Instantiate(gold, konum1.transform.position, Quaternion.identity);
                GameObject goldobje2 = Instantiate(gold, konum2.transform.position, Quaternion.identity);
                GameObject goldobje3 = Instantiate(gold, konum3.transform.position, Quaternion.identity);
                Debug.Log("altýn objesi oluþturdu");


            }

        }

        public void OnTriggerEnter(Collider nesne)
        {
            if (nesne.gameObject.tag == diamond_tag)
            {

                _market.para += diamondMoney;
                Debug.Log("Altýn toplandý - " + nesne.GetInstanceID() + " - " + _market.para);
                Destroy(nesne.transform.gameObject);
            }

        }


    }

    public class GameManager : MonoBehaviour
    {
        public CarController carController;
        public GoldSpawner goldSpawner;
        public int goldCount;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                goldSpawner.SpawnGold(goldCount);
                carController.StartCarMovement();
            }
        }
    }

    public class CarController : MonoBehaviour
    {
        public CarMovement carMovement;

        public void StartCarMovement()
        {
            carMovement.canMove = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Finish"))
            {
                carMovement.canMove = false;
            }
        }
    }
    public class CarMovement : MonoBehaviour
    {
        public WheelCollider onsoltekerlek, onsagtekerlek, arkasoltekerlek, arkasagtekerlek;
        public float motorhizi, donmehizi;
        public Joystick tus;

        public bool canMove;

        void Update()
        {
            if (canMove)
            {

                //ileri geri gitme
                arkasagtekerlek.motorTorque = motorhizi * -tus.Vertical;
                arkasoltekerlek.motorTorque = motorhizi * -tus.Vertical;
                //saða sola dönme
                onsagtekerlek.steerAngle = donmehizi * tus.Horizontal;
                onsoltekerlek.steerAngle = donmehizi * tus.Horizontal;
            }



        }
    }

    public class GoldSpawner : MonoBehaviour
    {
        public Gold goldRes;

        public void SpawnGold(int count)
        {
            for (int i = 0; i < count; i++)
            {

                Instantiate(goldRes, transform.position, Quaternion.identity);
            }
        }

    }

    public class Gold : MonoBehaviour
    {
        public int score;
    }
}


