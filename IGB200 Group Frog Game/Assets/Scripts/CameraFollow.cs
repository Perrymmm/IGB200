using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform CameraTarget;

    public float SmoothSpeed = 0.125f;

    public Vector3 offset;

    // Start is called before the first frame update
    void LateUpdate()
    {
        Vector3 desiredPosition = CameraTarget.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);

        transform.position = SmoothedPosition;

        //transform.LookAt(CameraTarget); //View 2 Option
    }
}
