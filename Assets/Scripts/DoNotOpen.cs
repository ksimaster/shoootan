using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotOpen : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelGameOver;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (panelGameOver.activeSelf)
        {
            panelMenu.SetActive(false);
            Time.timeScale = 0;
        }

    }

}
