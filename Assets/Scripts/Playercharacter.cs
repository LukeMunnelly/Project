using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercharacter : MonoBehaviour
{
    public int currentCoins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            

            currentCoins += collision.GetComponent<Coin>().coins;
            Destroy(collision.gameObject);
        }
    }

    public bool requiredCoins;
    //public Transform keyFollowPoint;

}
