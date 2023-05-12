using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarGame.ArabaHareket;

namespace CarGame
{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update

        public CarController carController;
        public GoldSpawner goldSpawner;
        public CarMovement carMovement;


        public int goldCount;
        public bool canMove;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                goldSpawner.SpawnGold(goldCount);
                carController.StartCarMovement();
            }
        }

      
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




}
