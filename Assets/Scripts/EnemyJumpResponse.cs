using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpResponse : MonoBehaviour
{
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jump"))
        {
            if (body != null)
            {
                JumpTrigger trigger = collision.gameObject.GetComponent<JumpTrigger>();
                Vector2 jumpHeight = trigger.JumpHeight;

                body.AddForce(jumpHeight, ForceMode2D.Impulse);
            }
        }
    }
}
