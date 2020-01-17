using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScene : MonoBehaviour
{
    public Slider Volume;
    public AudioSource myMusic;
    void Update()
    {
        myMusic.volume = Volume.value;
    }
    void Awake()

    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);



    }
}
