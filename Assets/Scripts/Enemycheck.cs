using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemy>())
            Destroy(transform.parent.gameObject);
    }
}
