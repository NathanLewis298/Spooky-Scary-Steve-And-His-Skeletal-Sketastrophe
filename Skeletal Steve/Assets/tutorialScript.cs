using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialScript : MonoBehaviour
{
    public GameObject tutorialText;
    public string tutorial;
    public int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            tutorialText.SetActive(true);
            tutorialText.GetComponent<Text>().text = tutorial;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutorialText.SetActive(false);
            Destroy(this);
        }
    }
}
