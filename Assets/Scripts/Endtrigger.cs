using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Endtrigger : MonoBehaviour
{
    public string SceneName;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        

        if(collider2D.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }


}
