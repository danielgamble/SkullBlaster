using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ButtonOptionsScreen : MonoBehaviour
{
    public void GoToOptionsScreen()
    {
        if (GameManager.instance != null) // Setting all screen states to false except for the game play screen
        {
            GameManager.instance.TitleScreenStateObject.SetActive(false);
            GameManager.instance.MainMenuStateObject.SetActive(false);
            GameManager.instance.OptionsScreenStateObject.SetActive(true);
            GameManager.instance.CreditsScreenStateObject.SetActive(false);
            GameManager.instance.GamePlayStateObject.SetActive(false);
            GameManager.instance.GameOverScreenStateObject.SetActive(false);


            SceneManager.LoadScene(3); // Load the Game Play screen.

           
        }

    }
}
