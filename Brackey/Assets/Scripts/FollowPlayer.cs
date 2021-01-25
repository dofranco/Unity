using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //this is to get the players transform
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //to get a message out to the console use debug
        // Debug.Log(player.position);

        //transform without capital T refers to the transform of the current object
        //transform.position = player.position;

        //but that causes a sort of first person view since the camera is alwasy in the SAME position
        // as the player. Instead, make the position to be the player position plus some offset,
        // which is set back in the Inspector
        transform.position = player.position + offset;
    }
}
