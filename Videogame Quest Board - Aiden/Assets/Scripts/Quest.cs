using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;
    
    public string title;
    public string description;
    public int experienceReward;
    public int goldReward;

    public void Complete()
    {
        isActive = false;
        Debug.Log(title + " was completed!");
    }

}
