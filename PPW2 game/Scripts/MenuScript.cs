using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    public Text HighScore;
    
	
    public void LoadingGame()
    {
       SceneManager.LoadScene("MainGame");
    }

    public void CloseGame()
    {
        Application.Quit();
    }

     void Update()
    {
        HighScore.text = "HighScore:\n \n" + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
