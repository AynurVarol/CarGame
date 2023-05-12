using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace CarGame
{
    public class ArabaSatinAl : MonoBehaviour
    {
        public float para;
        public GameObject[] arabalar;
        public GameObject panel;
        public bool a1, a2, a3;
        public Text sarıarabayazısı, maviarabayazısı, siyaharabayazısı;
        public CarSelectController carSelector;
        public Text ToplananGold;
        

        private void Awake()
        {
            carSelector = new CarSelectController();
        }
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                panel.SetActive(true);
            }
            
            ToplananGold.text = "Altın " + para;
        }

      

        

        public void AnaArabam()
        {
            CloseAllVehicles();
            arabalar[0].SetActive(true);
            panel.SetActive(false);
        }

        public void CloseAllVehicles()
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
            }

        }

        public void OpenVehicle(CarType type, int index)
        {
            CloseAllVehicles();
            arabalar[index].SetActive(true);
            panel.SetActive(false);
            switch (type)
            {
                case CarType.Red:
                    break;
                case CarType.Yellow:
                    a1 = true;
                    sarıarabayazısı.text = "Seçiniz";
                    carSelector.SelectedCar = arabalar[index];
                    break;
                case CarType.Blue:
                    a2 = true;
                    maviarabayazısı.text = "Seçiniz";
                    break;
                case CarType.Black:
                    a3 = true;
                    siyaharabayazısı.text = "Seçiniz";
                    break;
                default:
                    break;
            }

        }

        public void SarıAraba()
        {
            if (para >= 300 || a1)
            {
                para -= 300;
                OpenVehicle(CarType.Yellow, 1);

            }

        }


        public void MaviAraba()
        {
            if (para >= 450 || a2)
            {
                para -= 450;

                OpenVehicle(CarType.Blue, 2);

            }



        }

        public void SiyahAraba()
        {
            if (para >= 600 || a3)
            {
                para -= 600;

                OpenVehicle(CarType.Black, 3);

            }



        }

        public enum CarType
        {
            Red,
            Yellow,
            Blue,
            Black
        }

        public void MenuPaneliniAc()
        {
            panel.SetActive(true);

        }


        public void MenuPaneliniKapat()
        {
            panel.SetActive(false);

        }


    }

    



    public class CarSelectController
    {
        public GameObject SelectedCar { get; internal set; }
    }

   

}