using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarGame.ArabaHareket;

namespace CarGame
{

    public class GoldClon : MonoBehaviour
    {
        public GameObject gold;
        public Transform konum1, konum2, konum3;
        public float spawnDuration = 4.0f;
        public int diamondMoney = 100;

        public Gold goldRes; 
        private ArabaSatinAl _market;


        public const string diamond_tag = "Gold";

        public void StartInstantiateGold()
        {
            InvokeRepeating("Clon", 0, spawnDuration);
        }


        public void Clon()
        {
                GameObject goldobje = Instantiate(gold, konum1.transform.position, Quaternion.identity);
                GameObject goldobje2 = Instantiate(gold, konum2.transform.position, Quaternion.identity);
                GameObject goldobje3 = Instantiate(gold, konum3.transform.position, Quaternion.identity);
                Debug.Log("altýn objesi oluþturdu");


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
}
