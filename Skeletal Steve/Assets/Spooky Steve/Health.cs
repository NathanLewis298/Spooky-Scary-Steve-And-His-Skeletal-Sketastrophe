using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public int health;
    public bool hasDied;
    
    
    // Start is called before the first frame update
    void Start()
    {
     hasDied = false;
    }

    
    void Update()
    {
       if (gameObject.transform.position.y < -7) {
            hasDied = true;
        }
       if (hasDied == true) {
            StartCoroutine ("Die");
        }
    }
    IEnumerator Die() {
        SceneManager.LoadScene("Level 1 forest");
        yield return null;
    }
}

