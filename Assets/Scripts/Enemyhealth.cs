using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : Objecthealth
{
    public void HandleCollision(GameObject otherObject)
    {
        if (otherObject.CompareTag("Playercheck"))
        {
           Playercheck c = otherObject.GetComponent<Playercheck>();
            SubtractHealth(c.Damage);
        }
        
        base.HandleCollision(otherObject);
    }

    public void OnDeath()
    {
        base.OnDeath();
    }
}

