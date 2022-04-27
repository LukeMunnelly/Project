using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyai : MonoBehaviour
{

    public int Damage = 25;

    public float AttackRange = 2;
    GameObject Player;

    protected void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < AttackRange)
        {
            transform.up = Player.transform.position - transform.position;
        }
        else { }
    }
}
