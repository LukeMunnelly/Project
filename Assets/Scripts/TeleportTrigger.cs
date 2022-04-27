using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [HideInInspector]
    public Transform TeleportTo;

    private void Start()
    {
        TeleportTo = transform.GetChild(0);
    }
}
