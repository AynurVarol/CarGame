using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsagtekerlek, arkasoltekerlek, arkasagtekerlek;
    public float motorhizi, dönmehizi;
    public Joystick tus;
    
   
    
    void Update()
    {

        //ileri geri gitme
        arkasagtekerlek.motorTorque = motorhizi * tus.Vertical;
        arkasoltekerlek.motorTorque = motorhizi * tus.Vertical;
        //saða sola dönme
        önsagtekerlek.steerAngle = dönmehizi * tus.Horizontal;
        önsoltekerlek.steerAngle = dönmehizi * tus.Horizontal;


    }
}
