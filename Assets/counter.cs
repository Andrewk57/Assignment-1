using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    Text coin;  
    public static int cointAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
       coin = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = cointAmount.ToString();
    }
}
