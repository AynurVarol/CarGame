using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarGame.ArabaHareket;


namespace CarGame
{
    public class CarController : MonoBehaviour
    {
        // Start is called before the first frame update

        public CarMovement carMovement;

        public bool IsGameFinished { get; set; }

        public void StartCarMovement()
        {
            carMovement.canMove = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Finish"))
            {
                carMovement.canMove = false;
                IsGameFinished = true;
            }
        }






    }
} 
