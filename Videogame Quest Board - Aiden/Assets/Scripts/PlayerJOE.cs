using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJOE : MonoBehaviour
{

    public int experience = 0;
    public int experienceLevel = 1;
    public int gold = 0;
    public ExperienceTillNextLevel nextExp2;

    public Quest quest;

    void Start()
    {
        nextExp2 = FindObjectOfType<ExperienceTillNextLevel>();
    }
    public void GoBattle()
    {
        if (quest.isActive)
        {
            experience += quest.experienceReward;
            gold += quest.goldReward;
            quest.Complete();
        }
        print("Amount of experience you have is: " + experience);
        print("The level your at is: " + experienceLevel);
    }

}
