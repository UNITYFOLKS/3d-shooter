using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    Camera cam;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int posX = cam.pixelWidth / 2;
            int posY = cam.pixelHeight / 2;
            RaycastHit hit;
            Physics.Raycast(cam.ScreenPointToRay(new Vector3(posX, posY, 0)), out hit);

            if (hit.collider != null)
            {
                ReactiveTarget e = hit.collider.gameObject.GetComponentInParent<ReactiveTarget>();
                if (e != null)
                { e.ProcessDeath(); }

                StartCoroutine(Decal(hit.point));
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }

    void OnGUI()
    {
        int size = 12;
        float posX = cam.pixelWidth / 2 - size / 4;
        float posY = cam.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");//команда GUI.Label() отображает символ * 
    }

    //создаем сферу на месте попадания
    IEnumerator Decal(Vector3 point)
    {
        GameObject decal = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        decal.transform.position = point;

        yield return new WaitForSeconds(.2f);

        Destroy(decal);
    }
}
