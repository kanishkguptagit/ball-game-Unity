using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool game_paus = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (game_paus)
            {
                RESUME();
            }
             else
            {
                PAUSE();
            }
        }
    }
    public void RESUME()
    {
        pauseMenuUI.SetActive(false);
        game_paus = false;
        Time.timeScale = 1f;
    }
    void PAUSE()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        game_paus = true;
    }
    public void onPressMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void onPressQuit()
    {
        Application.Quit();
    }
}
