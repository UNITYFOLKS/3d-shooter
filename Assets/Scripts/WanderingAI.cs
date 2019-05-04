using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{

    private bool _alive;

    public float Speed = 3f;
    public float ObstacleRange = 5f;

    // Use this for initialization
    void Start()
    {
        _alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, .75f, out hit))
            {
                if (hit.distance < ObstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    public void SetAlive(bool isAlive)
    {
        _alive = isAlive;
    }
}
