/* Zach Wilson
 * Assignment 1
 * This script triggers the lose condition when the player falls off of the play area
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attach to the player
public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
