using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJOE : MonoBehaviour
{

    public int experience = 0;
    public int experienceLevel = 1;
    public int gold = 0;

    public Quest quest;


    public void GoBattle()
    {
        if (quest.isActive)
        {
            experience += quest.experienceReward;
            gold += quest.goldReward;
            quest.Complete();
        }
     
        if(experience >= 50)
        {
            experience = experience - 50;
            experienceLevel += 1;
        }
        print("Amount of experience you have is: " + experience);
        print("The level your at is: " + experienceLevel);
    }

}
