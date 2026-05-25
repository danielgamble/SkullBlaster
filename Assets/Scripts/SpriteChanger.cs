using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    // Declare our variables here
    public SpriteRenderer spriteRenderer;
    public Color spriteColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        // Put color change instructions here
        // Change the color property of the SpriteRenderer component to green
        if (spriteRenderer != null)
        {
            spriteRenderer.color = spriteColor;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
