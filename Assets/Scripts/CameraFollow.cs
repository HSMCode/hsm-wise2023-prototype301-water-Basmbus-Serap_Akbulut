using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCubeHeight : MonoBehaviour
{
    public Transform target; // Das Transform-Objekt des Cubes
    public float yOffset = 2f; // Der vertikale Offset zwischen der Kamera und dem Cube

    void Update()
    {
        if (target != null)
        {
            // Setze die Position der Kamera auf die Höhe des Cubes plus den Offset
            transform.position = new Vector3(transform.position.x, target.position.y + yOffset, transform.position.z);
        }
    }
}

