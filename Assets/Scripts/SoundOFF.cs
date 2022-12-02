using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOFF : MonoBehaviour
{
    private AudioSource audioObject;

    private void Start()
    {
        audioObject = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("SwitchSound") == 1) 
        {
            audioObject.volume = 1;
        }
        else
        {
            audioObject.volume = 0;
        }
        
        
    }
}
