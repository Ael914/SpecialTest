using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    public TMP_Text _highScore;
    void Start()
    {
        _highScore.text = "High score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
