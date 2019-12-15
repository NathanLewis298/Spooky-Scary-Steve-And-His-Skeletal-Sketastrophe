using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player_Score : MonoBehaviour
{
    private float timeLeft = 600;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public GameObject BodyUI;
    public List<GameObject> parts = new List<GameObject>();
    public Health health;
    public GameObject player;
    public bool swordPickedUp = false;

    // Update is called once per frame
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<Health>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        BodyUI.gameObject.GetComponent<Text>().text = ("X " + health.healthRemaining);
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

        if (trig.gameObject.name == "Body")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if (trig.gameObject.name == "Lungs")
        {
            BodyPartPickup(trig);
            parts.Add(trig.gameObject);
        }

        if(trig.gameObject.tag == "sword")
        {
            SoundManagerScript.PlaySound("Sword");
            swordPickedUp = true;
            Destroy(trig.gameObject);
        }

        

    }

    private void BodyPartPickup(Collider2D trig)
    {
        SoundManagerScript.PlaySound("PickUp");
        
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

