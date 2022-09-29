using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;
    public float FillSpeed = 0.5f;
    private float targetProgress = 0;
    public PlayerJOE player;
    private float exp = 0;
    public ExperienceTillNextLevel nextExp;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("Progress Bar Particles").GetComponent<ParticleSystem>();
        player = FindObjectOfType<PlayerJOE>();
        nextExp = gameObject.GetComponent<ExperienceTillNextLevel>();
    }

    void Start()
    {
        ////IncrementProgress(0.75f);
    }

    void Update()
    {
        if (exp < player.experience)
        {
            IncrementProgress((player.experience - exp)/nextExp.experienceTillNextLevel);
        } ////Check if player has gained exp and if they have, raise experience


        if (slider.value < targetProgress)
        {
            if (slider.value >= 1)
            {
                targetProgress = targetProgress - 1;
                slider.value = 0;
                player.experienceLevel += 1;
            }
            slider.value += FillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying)
                particleSys.Play();
        }
        else
        {
            particleSys.Stop();
        }


        exp = player.experience;
    }


    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
