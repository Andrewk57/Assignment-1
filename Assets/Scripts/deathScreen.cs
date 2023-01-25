using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScreen : MonoBehaviour
{
    public GameObject DeathScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SpikeScript.isDead==true)
        {

            Time.timeScale = 0f;
            AudioListener.volume = 0f;
            DeathScreen.SetActive(true);
        }
       else
        {
            AudioListener.volume = 1f;
            DeathScreen.SetActive(false);
        }
    }
}
