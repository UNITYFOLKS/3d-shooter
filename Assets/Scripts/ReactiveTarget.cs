using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public float Speed = 3.0f;

    // Use this for initialization
    void Start()
    {

    }

    public void ProcessDeath()
    {
        WanderingAI behaviour = GetComponent<WanderingAI>();
        behaviour.SetAlive(false);
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(1.5f);

        Destroy(gameObject);
    }
}
