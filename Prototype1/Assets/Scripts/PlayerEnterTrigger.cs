/* Zach Wilson
 * Assignment 1
 * This is the old script that managed score incrimentation that was attached to the player but is flawed in terms of design
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
