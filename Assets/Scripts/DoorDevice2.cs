using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDevice2 : MonoBehaviour
{
    public Transform door;
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>())
            OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponentInParent<Player>())
            CloseDoor();
    }

    private void OpenDoor()
    {
        if (isOpened)
            return;

        isOpened = true;
        door.transform.Translate(0, 0, -Distance);
    }

    private void CloseDoor()
    {
        if (!isOpened)
            return;

        isOpened = false;
        door.transform.Translate(0, 0, Distance);
    }
}
