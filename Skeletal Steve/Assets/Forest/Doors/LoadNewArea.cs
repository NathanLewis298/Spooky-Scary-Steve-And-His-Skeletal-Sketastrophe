using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour

{
    public string Hidden_Sword;
    public int requiredLives = 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Health health = other.gameObject.GetComponent<Health>();

            if (health.healthRemaining == requiredLives)
            {
                Application.LoadLevel ("EndLevel");
            }
        }
    }












}
