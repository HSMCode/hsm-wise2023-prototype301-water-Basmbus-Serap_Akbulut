using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cylinder")) // Überprüfe, ob das kollidierte Objekt ein "Cylinder"-Tag hat
        {
            Destroy(gameObject); // Zerstöre den Cube
            Debug.Log("Cube zerstört durch Kollision mit dem Zylinder. Du hast verloren.");
        }
    }
}

