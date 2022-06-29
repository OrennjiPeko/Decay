using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Text used in the code to change
    public Text timer;
    public Text score;
    //timer for the game
    float gametimer;
    public static int currentScore;

    // Use this for initialization
    void Start()
    {
        gametimer = 120f;

        currentScore = 0;
        score.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;
        timer.text = "" + gametimer.ToString("F0");
        score.text = "" + currentScore.ToString("F0");
        if (currentScore <= -1)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (gametimer == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (PlayerPrefs.GetInt("HighScore") < currentScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }

    }

} 
