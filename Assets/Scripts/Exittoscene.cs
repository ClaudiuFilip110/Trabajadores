using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exittoscene : MonoBehaviour
{
    public void BacktoMeniu(string backmenu)

    {
        
        SceneManager.LoadScene(backmenu);

    }
}
