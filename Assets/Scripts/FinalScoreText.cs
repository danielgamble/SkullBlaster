using SpaceAdventure.Asset;
using TMPro;
using UnityEngine;

public class FinalScoreText : MonoBehaviour
{
    public TMP_Text finalScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            finalScoreText.text = "Final Score" + GameManager.instance.Score;
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
