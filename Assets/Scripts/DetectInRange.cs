using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInRange : MonoBehaviour
{

    public Transform player;
    public float detectRange;
    public bool inRange = false;
    Rigidbody2D enemy;
    public float moveSpeed = 2f;

    private void Awake()
    {
        enemy = GetComponent<Rigidbody2D>();
        detectRange *= detectRange;
    }


    


    private void Update()
    {
        float distsqr = (player.position - transform.position).sqrMagnitude;
        if (distsqr <= detectRange)
        {
            inRange = true;
            Vector2 velocity = (player.transform.position - transform.position).normalized * moveSpeed;
            enemy.velocity = velocity;
        }
    }




    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRange);
    }
}
