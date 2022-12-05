using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController: MonoBehaviour
{
    public GameObject [] SoundOns;
    public GameObject [] SoundOffs;


    public AudioSource [] sounds;


    private void Start()
    {
      
        if (PlayerPrefs.HasKey("SwitchSound"))
        {
           /*
            if(PlayerPrefs.GetInt("SwitchSound") == 1)
            {
                textSoundON.SetActive(true);
                textSoundOFF.SetActive(false);
            }
            else
            {
                textSoundON.SetActive(false);
                textSoundOFF.SetActive(true);
            }
            */
            SoundSwitch(PlayerPrefs.GetInt("SwitchSound") == 1); // 1 - sound on (true), 0 - sound off (false)
            
        }
        else
        {
            PlayerPrefs.SetInt("SwitchSound", 1);
            SoundSwitch(PlayerPrefs.GetInt("SwitchSound") == 1);

        }
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.M ))
        {
            ButtonClick();
        }
        
    }

    public void ButtonClick()
    {
        if (PlayerPrefs.GetInt("SwitchSound") == 1)
        {
            PlayerPrefs.SetInt("SwitchSound", 0);
            SoundSwitch(PlayerPrefs.GetInt("SwitchSound") == 1);
        }
        else
        {
            PlayerPrefs.SetInt("SwitchSound", 1);
            SoundSwitch(PlayerPrefs.GetInt("SwitchSound") == 1);
        }
    }

    public void SoundSwitch(bool swichVar)
    {
        foreach (AudioSource s in sounds)
        {
           s.volume = swichVar ? 1f : 0f;
        }
        foreach (GameObject on in SoundOns)
        {
            on.SetActive(swichVar);
        }
        foreach (GameObject off in SoundOffs)
        {
            off.SetActive(!swichVar);
        }
        
     /*   if (swichVar)
        {
            PlayerPrefs.SetInt("SwitchSound", 0);
        }
        else
        {
            PlayerPrefs.SetInt("SwitchSound", 1);
        } */
        
    }



}
