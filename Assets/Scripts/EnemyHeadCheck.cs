using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeadCheck : MonoBehaviour
{
    [SerializeField]

    private Rigidbody2D player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Playercheck>())
        {
            player.velocity = new Vector2(player.velocity.x, 0f);
            player.AddForce(Vector2.up * 300f);
        }
    }
}
