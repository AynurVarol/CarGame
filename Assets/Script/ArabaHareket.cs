using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsağtekerlek, arkasoltekerlek, arkasağtekerlek;
    public float motorhizi, dönmehizi;
    public Joystick tuş;

    
    void Update()
    {  
        //ileri geri gitme
        arkasağtekerlek.motorTorque = motorhizi * tuş.Vertical;
        arkasoltekerlek.motorTorque = motorhizi * tuş.Vertical;
        //sağa sola dönme
        önsağtekerlek.steerAngle = dönmehizi * tuş.Horizontal;
        önsoltekerlek.steerAngle = dönmehizi * tuş.Horizontal;
    }
   


}
