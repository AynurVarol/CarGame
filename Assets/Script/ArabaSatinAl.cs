using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArabaSatinAl : MonoBehaviour
{
    public float para;
    public GameObject[] Arabalar;
    public GameObject panel;
    public bool a1, a2, a3;
    public Text sarýarabayazýsý, maviarabayazýsý, siyaharabayazýsý;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            panel.SetActive(true);
        }

    }

    public void anaArabam()
    {
        for (int i = 0; i < Arabalar.Length; i++)
        {
            Arabalar[i].SetActive(false);
            Arabalar[0].SetActive(true);
            panel.SetActive(false);



        }
    }

    public void sarýaraba()
    {
        if (para >= 300 || a1)
        {
            para -= 300;

            for (int i = 0; i < Arabalar.Length; i++)
            {
                Arabalar[i].SetActive(false);
                Arabalar[1].SetActive(true);
                panel.SetActive(false);
                a1 = true;
                sarýarabayazýsý.text = "Seçiniz";



            }
        }



    }


    public void maviaraba()
    {
        if (para >= 450 || a2)
        {
            para -= 450;

            for (int i = 0; i < Arabalar.Length; i++)
            {
                Arabalar[i].SetActive(false);
                Arabalar[2].SetActive(true);
                panel.SetActive(false);
                a2 = true;
                maviarabayazýsý.text = "Seçiniz";


            }
        }



    }

    public void siyaharaba()
    {
        if (para >= 600 || a3)
        {
            para -= 600;

            for (int i = 0; i < Arabalar.Length; i++)
            {
                Arabalar[i].SetActive(false);
                Arabalar[3].SetActive(true);
                panel.SetActive(false);
                a3 = true;
                siyaharabayazýsý.text = "Seçiniz";



            }
        }



    }

}
