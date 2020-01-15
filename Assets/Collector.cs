using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    
    public GameObject panel;
   
   
    void OnCollisionEnter(Collision collision)
    {
        panel.gameObject.SetActive(true);
        
        if (collision.collider.tag == "Coin")
        {
            Destroy(collision.gameObject);
            ScoreTextScript.coinAmount += 1;

        }  
    }
}
