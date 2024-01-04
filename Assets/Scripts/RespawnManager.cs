using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnManager : MonoBehaviour
{
    public GameObject buttonContinue; // the death message and reset button
    public GameObject buttonWin; //win message and restart button
    public GameObject jellyFish;
    public bool Death;
    public bool GameWon;
    // Update is called once per frame
    void Start ()
    {
        buttonContinue.SetActive(false); //hide the reset button
        buttonWin.SetActive(false);
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
        GameWon = jellyFish.GetComponent<CubeController>().GameWon;
        if (GameWon == true)
        {
            buttonWin.SetActive(true);
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
