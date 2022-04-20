using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtrigger2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        SceneManager.LoadScene(2);
    }
}
