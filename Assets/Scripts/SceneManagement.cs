using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject pausePanel, joystick, pauseButton;
    public void Pause()
    {
        pausePanel.SetActive(true);
        joystick.SetActive(false);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        pausePanel.SetActive(false);
        joystick.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
