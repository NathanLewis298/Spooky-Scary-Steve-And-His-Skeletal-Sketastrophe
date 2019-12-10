using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMove : MonoBehaviour
{
    public int EnemySpeed;
    public int XMoveDirection;
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
        if (hit.distance < 0.5f)
        {
            Flip();
            if (hit.collider.tag == "Player")
            {
                Health health = hit.collider.gameObject.GetComponent<Health>();
                Debug.Log(health.healthRemaining);
                health.healthRemaining = health.healthRemaining - 1;

                var partList = hit.collider.gameObject.GetComponent<Player_Score>().parts;
                partList[partList.Count - 1].SetActive(true);
                partList.Remove(partList[partList.Count - 1]);
                
            }

        }
       
    }
    void Flip ()
    {
        if (XMoveDirection > 0)
        {
            XMoveDirection = -1;
            transform.localScale = new Vector3(-5, 5);
        } else
        {
            XMoveDirection = 1;
            transform.localScale = new Vector3(5, 5);
        }
    }

}

