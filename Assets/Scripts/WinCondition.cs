using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public bool GameWon;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
            Debug.Log("Victory! Du hast das Level geschafft!");
            GameWon = true;
        }
    }
}

