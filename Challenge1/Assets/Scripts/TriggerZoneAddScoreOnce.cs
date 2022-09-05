/* Zach Wilson
 * Assignment 1
 * Manages the score being added to the player's score when the player enters a TriggerZone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
