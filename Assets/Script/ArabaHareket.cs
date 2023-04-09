using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public WheelCollider �nsoltekerlek, �nsagtekerlek, arkasoltekerlek, arkasagtekerlek;
    public float motorhizi, d�nmehizi;
    public Joystick tus;
    
   
    
    void Update()
    {

        //ileri geri gitme
        arkasagtekerlek.motorTorque = motorhizi * tus.Vertical;
        arkasoltekerlek.motorTorque = motorhizi * tus.Vertical;
        //sa�a sola d�nme
        �nsagtekerlek.steerAngle = d�nmehizi * tus.Horizontal;
        �nsoltekerlek.steerAngle = d�nmehizi * tus.Horizontal;


    }
}
