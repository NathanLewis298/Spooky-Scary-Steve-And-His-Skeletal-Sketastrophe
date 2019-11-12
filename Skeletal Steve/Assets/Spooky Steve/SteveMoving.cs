using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveMoving : MonoBehaviour
{

    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;
    public bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerRaycast();
    }

    void PlayerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }

        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
        Debug.Log("Is Grounded" + isGrounded);
    }


    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    void OnCollisionEnter2D(Collision2D col)
    {

    }

    void PlayerRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        if (hit != null && hit.collider != null && hit.distance < 1.2f && hit.collider.tag == "enemy")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 50);
            Destroy(hit.collider.gameObject);
        }



        Debug.Log("transform.position" + transform.position);

        Debug.Log("hit.point" + hit.point);
        // Debug.Log("hit.distance" + hit.distance);

        if (hit != null && hit.collider != null && hit.collider.tag != "enemy")
        {
            if (hit.distance < 1.2f)
            {

                isGrounded = true;
            }
            else
            {

                isGrounded = false;
            }
        }




    }




}

