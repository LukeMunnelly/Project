using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleportResponse : MonoBehaviour
{
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Teleport"))
        {
            TeleportTrigger teleport = collision.gameObject.GetComponent<TeleportTrigger>();
            body.MovePosition(teleport.TeleportTo.position);
        }
    }
}
