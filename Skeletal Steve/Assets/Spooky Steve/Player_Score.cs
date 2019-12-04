﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player_Score : MonoBehaviour
{
    private float timeLeft = 240;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("Level 1 forest");
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "EndLevel")
        {
            CountScore();
        }
        if (trig.gameObject.name == "Heart")
        {
            SoundManagerScript.PlaySound("PickUp");
            playerScore += 5;
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "Eye")
        {
            SoundManagerScript.PlaySound("PickUp");
            playerScore += 5;
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.name == "Brain")
        {
            SoundManagerScript.PlaySound("PickUp");
            playerScore += 5;
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.name == "Arms")
        {
            SoundManagerScript.PlaySound("PickUp");
            playerScore += 5;
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.name == "Head")
        {
            SoundManagerScript.PlaySound("PickUp");
            playerScore += 5;
            Destroy(trig.gameObject);
        }







    }
    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);
    }



}

