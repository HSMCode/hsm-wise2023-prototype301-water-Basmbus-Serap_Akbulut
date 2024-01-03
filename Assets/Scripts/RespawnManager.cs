using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnManager : MonoBehaviour
{
    public GameObject buttonContinue; // the death message and reset button
    public GameObject jellyFish;
    public bool Death;
    // Update is called once per frame
    void Start ()
    {
        buttonContinue.SetActive(false); //hide the reset button
    }
    void Update()
    {
        Death = jellyFish.GetComponent<DestroyOnCollision>().Death; //grab the Death Flag boolean from CylinderCollider.cs
        if (Death == true)
        {
            buttonContinue.SetActive(true); //activate the reset button
            if (Input.GetKeyDown("space"))
            {
                Resetti();
            }
        }
        
    }
    public void Resetti()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    //reload scene
    }
}
