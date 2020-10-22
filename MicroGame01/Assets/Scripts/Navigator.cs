using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    private string time;
    private string wpm;

    public TextMeshProUGUI Score;

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay Scene");
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void Start()
    {
        time = PlayerPrefs.GetString("TimerScore");
        wpm = PlayerPrefs.GetString("WPM");
    }

    void Update()
    {
        Score.text = $"{time}, {wpm}";
    }

}
