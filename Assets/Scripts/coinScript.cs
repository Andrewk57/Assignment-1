using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinScript : MonoBehaviour
{
    public TextMeshProUGUI amt;
    static public int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score++;
            amt.text = score.ToString();
            Destroy(gameObject);
        }
    }

}
