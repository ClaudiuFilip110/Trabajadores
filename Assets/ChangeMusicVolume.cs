using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour
{
    // Start is called before the first frame update

    
    public Slider Voulme;
    public AudioSource myMusic;
    void Update()
    {

    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    

    // Update is called once per frame
    
}
