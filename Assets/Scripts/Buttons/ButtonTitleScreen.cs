using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ButtonTitleScreen : MonoBehaviour
{
    public void GoToTitleScreen()
    {
        if (GameManager.instance != null) // Setting all screen states to false except for the game play screen
        {
            GameManager.instance.TitleScreenStateObject.SetActive(true);
            GameManager.instance.MainMenuStateObject.SetActive(false);
            GameManager.instance.OptionsScreenStateObject.SetActive(false);
            GameManager.instance.CreditsScreenStateObject.SetActive(false);
            GameManager.instance.GamePlayStateObject.SetActive(false);
            GameManager.instance.GameOverScreenStateObject.SetActive(false);


            SceneManager.LoadScene(0); // Load the Game Play screen.


        }

    }
}
