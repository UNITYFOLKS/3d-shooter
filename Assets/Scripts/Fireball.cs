using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    public float Speed = 3f;
    public int Damage = 10;

	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, Speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponentInParent<Player>();
        if(p != null)
        {
            p.Hurt(Damage);
            Debug.Log("HIT");
        }
        Destroy(gameObject);
    }
}
