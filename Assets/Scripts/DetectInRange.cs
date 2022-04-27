using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInRange : MonoBehaviour
{
    public float detectionRange = 5;
    public GameObject ObjectToTrack;

    bool alreadyDetected = false;

    private void Update()
    {
        if (Vector3.Distance(transform.position, ObjectToTrack.transform.position) <= detectionRange)
        {
            if (alreadyDetected == false)
            {
                OnDetected();
                alreadyDetected = true;
            }
        }
        else
        {
            alreadyDetected = false;
            OnLost();
        }
    }

    public virtual void OnDetected()
    {

    }

    public virtual void OnLost()
    {

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
