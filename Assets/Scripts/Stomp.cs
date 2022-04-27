using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomp : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<EnemyHeadCheck>())
            {
                Destroy(transform.parent.gameObject);
            }
        }

    }
}

