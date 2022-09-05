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
    public float minHeightCondition;
    public float maxHeightCondition;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < minHeightCondition || transform.position.y > maxHeightCondition)
        {
            ScoreManager.gameOver = true;
        }
    }
}
