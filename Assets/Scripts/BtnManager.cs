﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnManager : MonoBehaviour
{
    public void NewGameBtn(string newgamebtnlevel)
    {
        SceneManager.LoadScene(newgamebtnlevel);

    }
    public void ExitGame()
    {
        Application.Quit();

    }
}
