/* Zach Wilson
 * Assignment 1
 * Manages the camera to properly follow the player object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Commented rotation code isnt working and is getting sidelined until I've finished all the other requirements
public class FollowPlayerX : MonoBehaviour
{
    public float OffsetX;
    public float OffsetY;
    public float OffsetZ;
    //public float RotationX;
    //public float RotationY;
    //public float RotationZ;

    public GameObject player;
    private static Vector3 offset;
    //private static Vector3 rotation;

    private void Start()
    {
        offset = new Vector3(OffsetX, OffsetY, OffsetZ);
        //rotation = new Vector3(RotationX, RotationY, RotationZ);
        //transform.rotation.x = rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
