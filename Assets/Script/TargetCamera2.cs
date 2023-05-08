using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera2 : MonoBehaviour
{
    public Transform target;
   
    public Vector3 offset;
    public float rotationSpeed;
    public float translateSpeed;
    


    private Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
    }

    public void LateUpdate()
    {
        CameraMove();
        CameraRotate();
    }
   
    public void CameraRotate()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed);

        
    }

    public void CameraMove()
    {
        var targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed );
    }
}
