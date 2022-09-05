/* Zach Wilson
 * Assignment 1
 * Controles the rotation of the propeller spinning on the plane
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }
}
