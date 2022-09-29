using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntToText : MonoBehaviour
{
    public TextMeshProUGUI NextLevel;
    public TextMeshProUGUI PrevLevel;
    public PlayerJOE player;

    void Start()
    {
        player = FindObjectOfType<PlayerJOE>();
    }

    // Update is called once per frame
    void Update()
    {
        NextLevel.text = (player.experienceLevel + 1).ToString();
        PrevLevel.text = player.experienceLevel.ToString();
    }
}
