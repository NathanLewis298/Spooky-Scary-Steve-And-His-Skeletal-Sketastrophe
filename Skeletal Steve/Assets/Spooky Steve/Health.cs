using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public int healthRemaining = 3;
    public bool hasDied;


    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
    }


    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            hasDied = true;
        }
        if (hasDied == true)
        {
            StartCoroutine("Die");
        }

        if (healthRemaining == -1)
        {
            hasDied = true;
        } 

    }
    IEnumerator Die()
    {
        SoundManagerScript.PlaySound("Death");
        
        SceneManager.LoadScene("Death");
        yield return null;
    }
}

