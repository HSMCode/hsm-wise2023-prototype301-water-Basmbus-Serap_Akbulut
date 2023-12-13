using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpOnSpace : MonoBehaviour
{
    public float moveDistance = 1f; // Entfernung, um die sich das Objekt bewegen soll

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveUp();
        }
    }

    void MoveUp()
    {
        // Bewege das Objekt um die angegebene Entfernung nach oben
        transform.Translate(Vector3.up * moveDistance);
        Debug.Log("Leertaste gedrückt. Das Objekt wurde nach oben bewegt.");
    }
}

