using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI; 
    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Escape))
            if(GameIsPause)
            {
                Resume();

            }else
            {
                Pause();
            }

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public  void LoadingMenua()
    {
        SceneManager.LoadScene("Meniu");
    }
    public void Quitgame()
    {
        Debug.Log("Quitting the game ...");
        Application.Quit();
    }
}
