using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private Vector3 delta;

    private float _rotY;

    // Start is called before the first frame update
    void Start()
    {
        delta = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");

        _rotY += mx;

        Quaternion q = Quaternion.Euler(new Vector3(0, _rotY, 0));

        transform.position = target.position - (q * delta);

        transform.LookAt(target);
    }
}
