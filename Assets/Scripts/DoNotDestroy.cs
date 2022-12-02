using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private int pref = -1;

    static DoNotDestroy instance;
    void Start()
    {
        if (instance == null)
        { 
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        if (pref != -1) 
        {
            PlayerPrefs.SetInt("SwitchSound", pref);
        } 
        Debug.Log(pref);
    }

    void Update()
    {
        pref = PlayerPrefs.GetInt("SwitchSound");
        PlayerPrefs.SetInt("SwitchSound", pref);
        PlayerPrefs.Save();
        Debug.Log(pref);
    }

    
}
