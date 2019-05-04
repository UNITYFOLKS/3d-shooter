using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public GameObject head;

    public LookType lookType;

    public float maxVert = 45f;
    public float minVert = -45f;

    private float angleVert = 0;
    private float angleHor;

    public float sensivityH = 2f;
    public float sensivityV = 1.7f;

    // Update is called once per frame
    void Update()
    {
        if (lookType == LookType.MouseX)
        {
            float rotationX = Input.GetAxis("Mouse X") * sensivityH;
            transform.Rotate(0, rotationX, 0);
        }
        else if (lookType == LookType.MouseY)
        {
            float rotationVert = Input.GetAxis("Mouse Y") * sensivityV;
            angleVert -= rotationVert;
            // angleVert = angleVert - rotationY;

            angleVert = Mathf.Clamp(angleVert, minVert, maxVert);

            float rotationY = head.transform.rotation.y;

            //(x,y,z)
            head.transform.rotation = Quaternion.Euler(new Vector3(angleVert, rotationY, 0));
        }
        else
        {
            float rotationVert = Input.GetAxis("Mouse Y") * sensivityV;
            float rotationHor = Input.GetAxis("Mouse X") * sensivityH;

            angleVert -= rotationVert;
            // angleVert = angleVert - rotationY;

            angleVert = Mathf.Clamp(angleVert, minVert, maxVert);

            angleHor += rotationHor;

            //(x,y,z)
            transform.rotation = Quaternion.Euler(new Vector3(0, angleHor, 0));
            head.transform.rotation = Quaternion.Euler(new Vector3(angleVert, angleHor, 0));
        }
    }
}

public enum LookType
{
    MouseX,
    MouseY,
    MouseXY
}
