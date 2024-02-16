using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private int sec = 0;
    public GameObject _joystick, _winPanel, _pauseButton;
    public TMP_Text _winText, _timer;
    private int score;


    private void OnTriggerEnter(Collider other)
    {
        score = int.Parse(_timer.text);
        if (PlayerPrefs.GetInt("HighScore") > score || PlayerPrefs.GetInt("HighScore") == 0)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        _winText.text = "Victory!";
        _winPanel.SetActive(true);
        _pauseButton.SetActive(false);
        _timer.enabled = false;
        _joystick.SetActive(false);
        StartCoroutine(ITimer());
        

    }
    IEnumerator ITimer()
    {
        while (sec < 3)
        {
            sec++;
            yield return new WaitForSeconds(1);

        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
