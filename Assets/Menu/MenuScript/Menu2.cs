using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CarGame
{
    public class Menu2 : MonoBehaviour
    {
        public Canvas canvas;
        public Button purchaseButton;
        public Button backButton;
        public GameObject purchasePanel;
        public TMPro.TextMeshProUGUI purchaseText;

        private void Awake()
        {
            canvas.worldCamera = Camera.main;
            purchaseButton.onClick.AddListener(SetPanelActive);
            backButton.onClick.AddListener(SetPanelActive);
        }

        private void SetPanelActive()
        {
            if (purchasePanel.activeSelf)
            {
                purchasePanel.SetActive(false);
            }
            else
            {
                purchasePanel.SetActive(true);
            }
        }

        public void SetText(string str)
        {
            purchaseText.text = str;
        }
    }
}
