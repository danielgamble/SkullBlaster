using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ButtonPlayAgain : MonoBehaviour
{
    public void PlayAgain()
    {
        if (GameManager.instance != null)
        {
            SceneManager.LoadScene(1); // Load the Gameplay screen when the player clicks Play Again.
           // GameManager.instance.Score = 0; // Reset the score to 0
          
            Health health = GetComponent<Health>(); // Access the health component
            
            if (health != null)
            {
                health.currentHealth = health.maxHealth; // Reset health to the max health value.
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
}