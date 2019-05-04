using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTutorial : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            anim.SetTrigger("Go");
        }
    }

    void OnJump()
    {
        GetComponentInChildren<ParticleSystem>().Play();
    }
}
