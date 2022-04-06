using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canJump = false;
    //horizontal movement
    public float movementSpeed = 5;
    //vertical movement
    public Vector2 jumpHeight = new Vector2(0, 5);

    Rigidbody2D body;
    //used to store the players next X and Y movement
    Vector2 nextMovement;
    SpriteRenderer spriteRenderer;

    //Checkpoint
    Vector2 lastCheckpointPosition;

    public int MaxAllowedJumps = 2;
   public int jumpCount;
    public bool isOnLadder = false;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        //default checkpoint position, position at the start of the game
        lastCheckpointPosition = transform.position;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ReturnToCheckpoint();
        }

        #region Input
    

        if (!isOnLadder)
        {
            nextMovement.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
            //has the player pressed the jump key
            if (Input.GetButtonDown("Vertical") && canJump)
            {
                if (jumpCount <= MaxAllowedJumps)
                {
                    //jump, add some force to the rigid body
                    body.AddForce(jumpHeight, ForceMode2D.Impulse);
                    jumpCount++;
                }
                else
                {
                    canJump = false;//can't jump, once we go over the MaxAllowedJumps
                }
            }


            //maintain Y velocity, copying the Y velocity from physics system
            nextMovement.y = body.velocity.y;

            body.velocity = nextMovement;
        }
        else
        {
            nextMovement.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
            nextMovement.y = Input.GetAxisRaw("Vertical") * movementSpeed;
            body.velocity = nextMovement;
        }

        //change the sprite flip, based on the x movement
        if(nextMovement.x > 0)//positive x = facing right,
        {
            spriteRenderer.flipX = false;
        }
        else if (nextMovement.x < 0)//negative x = facing left
        {
            spriteRenderer.flipX = true;
        }
        #endregion
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ladder"))
        {
            isOnLadder = true;
            body.gravityScale = 0;
        }
        //if the object is tagged as Checkpoint
        //if(collision.CompareTag("Checkpoint"))
        //{
        //    //save the position of the checkpoint
        //    lastCheckpointPosition = collision.gameObject.transform.position;
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            isOnLadder = false;
            body.gravityScale = 1;
        }
    }

    void ReturnToCheckpoint()
    {
        transform.position = lastCheckpointPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CheckIfCanJump(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        CheckIfCanJump(collision);
    }

    private void CheckIfCanJump(Collision2D collision)
    {
        if (collision.contactCount > 0)
        {
            ContactPoint2D contact = collision.contacts[0];

            //if the the normal is the same dircetion as Vector2.Up -> 1.0 if the same, 0.0f if there not
            if (Vector2.Dot(contact.normal, Vector2.up) > 0.5f)
            {
                jumpCount = 0;
                canJump = true;
            }
            else
            {
                canJump = false;
            }
        }
    }

    //Vector3 normal;
    //Vector3 collisionPoint;
    //public Color debugColor;
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawLine(collisionPoint, collisionPoint + normal * 2);
    //}
}
