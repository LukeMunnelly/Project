using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercheck : MonoBehaviour
{

    public int Damage = 25;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyHeadCheck>())
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
