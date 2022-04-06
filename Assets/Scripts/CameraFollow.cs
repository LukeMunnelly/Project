using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //the transform (position, rotations and scale, component)
    public Transform ObjectToFollow;

    void Update()
    {
        //camera position is now set to the position of the object we are following
        transform.position = new Vector3(
            ObjectToFollow.position.x,//x position of teh player
            ObjectToFollow.position.y,//y position of the player
            -1);//set the Z to above the player
    }
}
