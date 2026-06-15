using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    // Declare our variables
    public SpriteRenderer theRenderer;
    public Color spriteColor; // Variable for our color
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load the SpriteRenderer component from the same object this component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();

        // Change the color from our color picker so that the alpha is 1
        spriteColor.a = 1.0f;
        // Change the "color" value of the SpriteRenderer component to our new color
        theRenderer.color = spriteColor;

        // As long as theRenderer has been set
        if (theRenderer != null)
        {
            // Change the "color" value of teh SpriteRenderer component to our new color
            theRenderer.color = spriteColor;
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------    
}
