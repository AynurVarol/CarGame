using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera2 : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;
    public float rotationSpeed;
    public Vector3 min,max;


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
    public void CameraMove()
    {
        _cam.transform.position = Vector3.MoveTowards(_cam.transform.position, target.position + offset, speed );
    }
    public void CameraRotate()
    {

        var targetRotation = Quaternion.Lerp(_cam.transform.rotation, target.localRotation, rotationSpeed * Time.deltaTime);
        targetRotation.x = 0;
        targetRotation.z = 0;

        targetRotation.eulerAngles = new Vector3(0, Mathf.Clamp(targetRotation.eulerAngles.y, min.y, max.y), 0);
        _cam.transform.rotation = targetRotation;

    }
}
