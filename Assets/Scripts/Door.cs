using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Playercharacter thePlayer;
    public int requiredCoins;

     void Start()
    {
        thePlayer = FindObjectOfType<Playercharacter>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Player")
        {
            if(thePlayer.currentCoins != requiredCoins)
            {
               Destroy(gameObject);
            }
            else if(thePlayer.currentCoins <= requiredCoins)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

    }
}
