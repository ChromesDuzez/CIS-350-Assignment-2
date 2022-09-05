/* Zach Wilson
 * Assignment 1
 * Manages the camera to properly follow the player object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public float OffsetX;
    public float OffsetY;
    public float OffsetZ;
    public GameObject player;
    private static Vector3 offset;

    private void Start()
    {
        offset = new Vector3(OffsetX, OffsetY, OffsetZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; 
    }
}
