using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercheck : MonoBehaviour
{
    public BoxCollider2D PlayerCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyHeadCheck>())
        {
            Destroy(transform.parent.gameObject);
        }
    }



}
    

