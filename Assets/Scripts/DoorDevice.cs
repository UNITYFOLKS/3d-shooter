using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDevice : MonoBehaviour
{
    public Transform detector;
    public float Radius = 5;
    public float Distance = 20;

    bool isOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // сюда мы будем сохранять объекты которые попали под 
        // датчик
        Collider[] colliders; 

        colliders = Physics.OverlapSphere(detector.position, Radius);

        foreach(Collider c in colliders)//для каждого
        {
            Player p = c.GetComponentInParent<Player>();
            if(p != null)
            {
                OpenDoor();
            }
            else
            {
                CloseDoor();
            }
        }
    }

    private void OpenDoor()
    {
        if (isOpened)
            return;

        isOpened = true;
        transform.Translate(0, 0, -Distance);
    }

    private void CloseDoor()
    {
        if (!isOpened)
            return;

        isOpened = false;
        transform.Translate(0, 0, Distance);
    }
}
