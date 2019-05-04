using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    int health;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hurt(int damage)
    {
        health -= damage;
    }

    private void OnGUI()
    {
        Texture2D img = Resources.Load<Texture2D>("icons/HP");
        GUI.Box(new Rect(10, 10, 100, 30), new GUIContent("health", img));
    }
}
