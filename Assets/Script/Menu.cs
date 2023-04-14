using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CarGame
{
    public class Menu : MonoBehaviour
    {
        public GameObject menupaneli;

        [System.Obsolete]
        public void OyunuBaslat()
        {
            Application.LoadLevel(1);
            Time.timeScale = 1.0f;
        }


        public void MenuyuAc()
        {
            menupaneli.SetActive(true);
            Time.timeScale = 0.0f;

        }

        public void OyunaDevamEt()
        {
            menupaneli.SetActive(false);
            Time.timeScale = 1.0f;

        }

        [System.Obsolete]
        public void AnaMenuyeGit()
        {
            Application.LoadLevel(0);
        }






    }
}
