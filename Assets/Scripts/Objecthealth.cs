using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecthealth : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollision(collision.gameObject);
    }

    ////public void AddHealth(int amount)
    //{
    //    Health += amount;

    //    if (Health > MaxHealth)
    //        Health = MaxHealth;

    //    OnHealthUpdated();
    //}

    public void SubtractHealth(int amount)
    {
        Health -= amount;

        if (Health <= 0)
            OnDeath();

        OnHealthUpdated();
    }



    public virtual void OnHealthUpdated() { }
    public virtual void OnDeath() { }
    public virtual void HandleCollision(GameObject otherObject) { }
}
