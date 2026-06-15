using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ButtonPressToStart : MonoBehaviour
{
    public void ChangeToGamePlayScreen()
    {
        if (GameManager.instance != null) // Setting all screen states to false except for the game play screen
        {
            GameManager.instance.TitleScreenStateObject.SetActive(false);
            GameManager.instance.MainMenuStateObject.SetActive(false);
            GameManager.instance.OptionsScreenStateObject.SetActive(false);
            GameManager.instance.CreditsScreenStateObject.SetActive(false);
            GameManager.instance.GamePlayStateObject.SetActive(true);
            GameManager.instance.GameOverScreenStateObject.SetActive(false);

            
            SceneManager.LoadScene(1); // Load the Game Play screen.
            
            Debug.Log ("Game Play Activated");
        }
        
    }
}
