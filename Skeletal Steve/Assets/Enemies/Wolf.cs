using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Wolf : MonoBehaviour
{
    public int WolfSpeed;
    public int WMoveDirection;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(WMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(WMoveDirection, 0) * WolfSpeed;
        if (hit.distance < 1.4f)
        {

            Rotate();
            if (hit.collider.tag == "Player")
            {
                SoundManagerScript.PlaySound("Death");
                Health health = hit.collider.gameObject.GetComponent<Health>();
                Debug.Log(health.healthRemaining);
                health.healthRemaining = health.healthRemaining - 1;

                var partList = hit.collider.gameObject.GetComponent<Player_Score>().parts;
                partList[partList.Count - 1].SetActive(true);
                partList.Remove(partList[partList.Count - 1]);
            }

        }

    }
    void Rotate()
    {
        if (WMoveDirection > 0)
        {
            WMoveDirection = -1;
            transform.localScale = new Vector3(-1, 1);
        }
        else
        {
            WMoveDirection = 1;
            transform.localScale = new Vector3(1, 1);
        }
    }

}

