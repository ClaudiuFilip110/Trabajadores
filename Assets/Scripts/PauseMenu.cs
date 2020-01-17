using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPause = false;
    public GameObject pauseMenuCredits;
    public GameObject Caracter;
    public GameObject Minimap;
    public GameObject pauseMenu;
    public GameObject pauseCOIN;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUI2;
    // Update is called once per frame
    void Update()
    
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
            if(GameIsPause)
            {   
                Resume();
              
            }
            else
            {
                Pause();
            }

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseCOIN.SetActive(true);
        Minimap.SetActive(true);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause()
    {
        pauseCOIN.SetActive(false);
        Minimap.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void Play()
    {
        Minimap.SetActive(true);
        pauseCOIN.SetActive(true);
        pauseMenu.SetActive(false);
       
        
    }


    public void SetSettings()
    {
        pauseMenuUI.SetActive(false);
        pauseMenuUI2.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void SetfromMenuSettings()
    {
        pauseMenu.SetActive(false);
        pauseMenuUI2.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void BackSettings()
    {
        pauseMenuUI2.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void BackToPlay()
    {
        Minimap.SetActive(false);
        pauseCOIN.SetActive(false);
        pauseMenuUI2.SetActive(false);
        pauseMenu.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void CreditsTime()
    {
        pauseMenu.SetActive(false);
        pauseMenuCredits.SetActive(true);
        Time.timeScale = 1f;
        GameIsPause = true;
    }
    public void backCreditsTime()
    {
        pauseMenu.SetActive(true);
        pauseMenuCredits.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
        public  void LoadingMenua()
    {
        SceneManager.LoadScene("Meniu");

    }
    public void FullScreen()
    {
       
            // Toggle fullscreen
            Screen.fullScreen = !Screen.fullScreen;
        Screen.SetResolution(1920, 1080, false);
    }
    public void Windowed()
    {
              
            // Switch to 800 x 600 windowed
            Screen.SetResolution(1400, 1050, false);
        
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void Quitgame()
    {
        Debug.Log("Quitting the game ...");
        Application.Quit();
    }
}
