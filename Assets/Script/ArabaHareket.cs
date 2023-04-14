using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public WheelCollider onsoltekerlek, onsagtekerlek, arkasoltekerlek, arkasagtekerlek;
    public float motorhizi, donmehizi;
    public Joystick tus;
    
   
    
    void Update()
    {

        //ileri geri gitme
        arkasagtekerlek.motorTorque = motorhizi * -tus.Vertical;
        arkasoltekerlek.motorTorque = motorhizi * -tus.Vertical;
        //saða sola dönme
        onsagtekerlek.steerAngle = donmehizi * tus.Horizontal;
        onsoltekerlek.steerAngle = donmehizi * tus.Horizontal;


    }
}
