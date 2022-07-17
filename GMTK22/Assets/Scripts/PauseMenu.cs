using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    private bool pausedState;


    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void TurnOnPauseMenu(bool isOn)
    {

        if (isOn == true)
        {
            GameIsPaused = !GameIsPaused;
            if (GameIsPaused == true)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }



    }

    public void LoadMenu(){
        Debug.Log("Loading menu");
    }
    
    public void QuitGame(){
    Debug.Log("Quitting game");
    }
}
