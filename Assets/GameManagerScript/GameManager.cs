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
        public GoldClon goldClone;


        public int goldCount;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                goldSpawner.SpawnGold();
                carController.StartCarMovement();
                goldClone.StartInstantiateGold();
            }
            if (carController.IsGameFinished)
            {
                Debug.Log("oyun bitti");
            }
        }

      
        public void StartGame()
        {
            carController.StartCarMovement();

        }





    }




}
