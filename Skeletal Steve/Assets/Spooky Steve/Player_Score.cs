using System.Collections;
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
    public List<GameObject> parts = new List<GameObject>();

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
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }
        if (trig.gameObject.name == "Eye")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if (trig.gameObject.name == "Brain")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if (trig.gameObject.name == "Arms")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if (trig.gameObject.name == "Head")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if (trig.gameObject.name == "Legs")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }





    }

    private void BodyPartPickup(Collider2D trig)
    {
        SoundManagerScript.PlaySound("PickUp");
        playerScore += 5;
        GameObject player = GameObject.Find("Player");
        Health health = player.GetComponent<Health>();
        health.healthRemaining = health.healthRemaining + 1;
        trig.gameObject.SetActive(false);
    }

    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);
    }



}

