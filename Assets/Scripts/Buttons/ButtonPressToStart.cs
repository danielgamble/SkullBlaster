using UnityEngine;

public class ButtonPressToStart : MonoBehaviour
{
    public void ChangeToMainMenu()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.TitleScreenStateObject.SetActive(false);
            GameManager.instance.MainMenuStateObject.SetActive(false);
            GameManager.instance.OptionsScreenStateObject.SetActive(false);
            GameManager.instance.CreditsScreenStateObject.SetActive(false);
            GameManager.instance.GamePlayStateObject.SetActive(false);
            GameManager.instance.GameOverScreenStateObject.SetActive(false);
            GameManager.instance.ActivateMainMenu();
            Debug.Log ("Main Menu Activated");
        }
        
    }
}
