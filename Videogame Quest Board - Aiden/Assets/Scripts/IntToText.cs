using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

/// <summary>
/// This whole script practicly just takes the numbers from the Player object and shows them on the Canvas
/// </summary>

public class IntToText : MonoBehaviour
{
    public TextMeshProUGUI NextLevel;
    public TextMeshProUGUI PrevLevel;
    public TextMeshProUGUI ExpNum;
    public PlayerJOE player;
    public ExperienceTillNextLevel ExperienceTillNextLevel;


    void Start()
    {
        player = FindObjectOfType<PlayerJOE>();
    }

    // Update is called once per frame
    void Update()
    {
        NextLevel.text = (player.experienceLevel + 1).ToString();
        PrevLevel.text = player.experienceLevel.ToString();
        ExpNum.text = ((player.experience-(ExperienceTillNextLevel.experienceTillNextLevel*player.experienceLevel)+50)+ ("/") + (ExperienceTillNextLevel.experienceTillNextLevel)).ToString();

    }
}
