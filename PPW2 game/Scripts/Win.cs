using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("Score") < Timer.currentScore)
        {
            PlayerPrefs.SetInt("Score", Timer.currentScore);
        }

        SceneManager.LoadScene("MainMenu");
    }
}
