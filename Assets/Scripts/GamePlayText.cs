using TMPro;
using UnityEngine;

public class GamePlayText : MonoBehaviour
{
    public TMP_Text scoreText; // TMP_Text is the equivilent of int, float, GameObject, etc. when using to change variables in the inspector
    public TMP_Text livesText; // Creating a variable to allow us to change the text to reflect the number of lives left

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameManager.instance.Score;
        livesText.text = "Lives: " + GameManager.instance.Lives;
    }
}
