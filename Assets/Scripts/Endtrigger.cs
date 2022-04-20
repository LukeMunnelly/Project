using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        SceneManager.LoadScene(1);
    }
}
