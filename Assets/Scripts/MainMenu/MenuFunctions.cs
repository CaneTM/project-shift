using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class is primarily used to hold a bunch of methods related to main menu functionality 
public class MenuFunctions : MonoBehaviour
{
    public string firstScene = "Game";

    // Loads the first scene of the game upon clicking Play
    public void StartGame()
    {
        SceneManager.LoadScene(firstScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
