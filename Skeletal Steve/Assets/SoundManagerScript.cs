using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip enemyDeathSound, PickUpSound, DeathSound, WoodenDoorSound, JumpSound;
    static AudioSource audioSrc;
    void Start()
    {
        enemyDeathSound = Resources.Load<AudioClip>("enemyDeath");

        PickUpSound = Resources.Load<AudioClip>("PickUp");

        DeathSound = Resources.Load<AudioClip>("Death");

        WoodenDoorSound = Resources.Load<AudioClip>("WoodenDoor");

        JumpSound = Resources.Load<AudioClip>("Jump");


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "enemyDeath":
                audioSrc.PlayOneShot (enemyDeathSound);
                break;

            case "PickUp":
                audioSrc.PlayOneShot(PickUpSound);
                break;


            case "Death":
                audioSrc.PlayOneShot(DeathSound);
                break;

            case "WoodenDoor":
                audioSrc.PlayOneShot(WoodenDoorSound);
                break;

            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;

        }
    }



















}



