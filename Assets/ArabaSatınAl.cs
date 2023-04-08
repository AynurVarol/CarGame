using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaSatınAl : MonoBehaviour
{
    public float para;
    public GameObject[] Arabalar;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D));
        {
            panel.SetActive(true);
        }
        
    }
    
    public void anaarabam()
    {
        for(int i = 0; i < Arabalar.Length; i++)
        {
            Arabalar[i].SetActive(false);
            Arabalar[0].SetActive(true);
            panel.SetActive(false);
        }

    }

    public void anaarabam()
    {
        for(int i = 0; i < Arabalar.Length; i++)
        {
            Arabalar[i].SetActive(false);
            Arabalar[0].SetActive(true);
            panel.SetActive(false);
        }

    }


}