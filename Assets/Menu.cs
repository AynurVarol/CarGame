using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menupaneli;

    public void OyunuBaslat()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1.0f;
    }


    public void menuyuAc()
    {
        menupaneli.SetActive(true);
        Time.timeScale = 0.0f;

    }

    public void oyunaDevamEt()
    {
        menupaneli.SetActive(false);
        Time.timeScale = 1.0f;

    }

    public void AnaMenuyeGit()
    {
        Application.LoadLevel(0);
    }






}
