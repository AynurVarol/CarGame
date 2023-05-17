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
        public Text sarýarabayazýsý, maviarabayazýsý, siyaharabayazýsý;
        public CarSelectController carSelector;
        public Text ToplananGold;
        public int _yellowCarMoney = 300;
        public int _blueCarMoney = 450;
        public int _blackCarMoney = 600;
        
        public Menu2 menu;
        
            
        


        private void Awake()
        {
            carSelector = new CarSelectController();
            
            menu.SetText(_yellowCarMoney.ToString());
            menu.SetText(_blueCarMoney.ToString());
            menu.SetText(_blueCarMoney.ToString());
        }

      
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                panel.SetActive(true);
            }
            
            ToplananGold.text = "Altýn " + para;
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
                    sarýarabayazýsý.text = "Seçiniz";
                    carSelector.SelectedCar = arabalar[index];
                    break;
                case CarType.Blue:
                    a2 = true;
                    maviarabayazýsý.text = "Seçiniz";
                    break;
                case CarType.Black:
                    a3 = true;
                    siyaharabayazýsý.text = "Seçiniz";
                    break;
                default:
                    break;
            }

        }

        public void SarýAraba()
        {
            if (para >= _yellowCarMoney || a1)
            {
                para -= _yellowCarMoney;
                OpenVehicle(CarType.Yellow, 1);

            }

        }


        public void MaviAraba()
        {
            if (para >= _blueCarMoney || a2)
            {
                para -= _blueCarMoney;

                OpenVehicle(CarType.Blue, 2);

            }



        }

        public void SiyahAraba()
        {
            if (para >= _blackCarMoney|| a3)
            {
                para -= _blackCarMoney;

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