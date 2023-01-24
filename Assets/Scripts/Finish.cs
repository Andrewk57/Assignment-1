using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject FinishScreen;

    private void Start()
    {
        Time.timeScale = 1f;
        FinishScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        FinishScreen.SetActive(true);
    }

}
