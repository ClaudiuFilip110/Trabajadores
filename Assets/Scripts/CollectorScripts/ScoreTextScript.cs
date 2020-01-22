using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {   if (coinAmount < 15)
            text.text = "Coins: " + coinAmount.ToString() + "/15";
        else
            text.text = "Felicitari 15/15 ";


        
    }
}
