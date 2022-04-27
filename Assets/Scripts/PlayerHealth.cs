using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Objecthealth
{
    public void OnHealthUpdated()
    {
        float convertedHealth = (float)Health / (float)MaxHealth;
        convertedHealth = Mathf.Clamp(convertedHealth, 0.0f, 1.0f);
    }

    private void Start()
    {
        OnHealthUpdated();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        HandleCollision(collision.gameObject);
    }

    public void HandleCollision(GameObject otherObject)
    {
        base.HandleCollision(otherObject);
    }

    public void OnDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        base.OnDeath();
    }
}
