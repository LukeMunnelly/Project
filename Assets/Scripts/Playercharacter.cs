using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercharacter : MonoBehaviour
{
    public int currentCoins = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            currentCoins++;

            currentCoins += collision.GetComponent<Coin>().coins;
            Destroy(collision.gameObject);
        }
    }
}
