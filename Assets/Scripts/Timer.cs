using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int sec = 0;
    public TMP_Text _timer;
    public GameObject _joystick, _losePanel, _pauseButton, _trigger;

    private void Start()
    {
        StartCoroutine(ITimer());
        _timer.enabled = false;
    }
    IEnumerator ITimer()
    {
        while (sec < 26)
        {
            sec++;
            if (sec == 3)
            {
                _joystick.SetActive(true);
                _pauseButton.SetActive(true);
                _timer.enabled = true;
            }
            if (sec == 23)
            {
                _losePanel.SetActive(true);
                _joystick.SetActive(false);
                _pauseButton.SetActive(false);
                _trigger.SetActive(false);
                _timer.enabled = false;
            }
            _timer.text = (sec - 3).ToString("D2");
            yield return new WaitForSeconds(1);

        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
