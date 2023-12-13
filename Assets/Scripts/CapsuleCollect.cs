using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Capsule")) // Überprüfe, ob das kollidierte Objekt ein "Capsule"-Tag hat
        {
            Destroy(other.gameObject); // Zerstöre die Kapsel
            Debug.Log("Capsule aufgesammelt!");
        }
    }
}

