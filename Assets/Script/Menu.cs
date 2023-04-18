using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CarGame
{
    public class Menu : MonoBehaviour
    {
        public GameObject menupaneli;
        public GameObject panel;
        public Button menuButton;
        public Button panelButton;

        private void Awake()
        {
            menuButton.onClick.AddListener(OnMenuButtonClicked);
            panelButton.onClick.AddListener(OnPanelButtonClicked);
        }

        private void OnPanelButtonClicked()
        {
            var isActive = panel.gameObject.activeSelf;
            panel.gameObject.SetActive(!isActive);
        }

        private void OnMenuButtonClicked()
        {
            bool isActive = menupaneli.gameObject.activeSelf;
            menupaneli.gameObject.SetActive(!isActive);
        }

        [System.Obsolete]
        public void AnaMenuyeGit()
        {
            Application.LoadLevel(0);
        }






    }
}
