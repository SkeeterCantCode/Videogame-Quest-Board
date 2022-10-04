using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject iconPicker;
    public bool playerIsNew = false;
    float newplayerstate;
    bool hasIcon;

    private void Awake()
    {
        newplayerstate = PlayerPrefs.GetFloat("newPlayerState");

        if(newplayerstate == 0)
        {
            playerIsNew = false;
        }    
        else
        {
            playerIsNew = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (playerIsNew)
        {
            InizializaPlayer();
        }
        else
        {
            return;
        }
    }

    private void InizializaPlayer()
    {
        iconPicker.SetActive(true);
        hasIcon = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        if (playerIsNew)
        {
            newplayerstate = 1;
        }
        else
        {
            newplayerstate = 0;
        }

        PlayerPrefs.SetFloat("newPlayerState", newplayerstate);
    }
}
