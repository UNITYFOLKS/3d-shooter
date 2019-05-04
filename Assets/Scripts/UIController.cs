using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public bool MenuActive = true;
    public float EnemySpeed = 3;

    public GameObject menu;
    public void ShowMenu()
    {
        MenuActive = true;
        menu.SetActive(true);
    }

    public void CloseMenu()
    {
        MenuActive = false;
        menu.SetActive(false);
    }

    public void SetEnemySpeed(float s)
    {
        EnemySpeed = s;
    }
}
