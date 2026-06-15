using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    // Create a variable for our transform component
    private Transform tf;
    // Create a variable for the max we can scale in one frame draw
    public float maxScale;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {

        // Load our component into our variable
        tf = GetComponent<Transform>();

    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        // Find out how far and in which direction our axes are pressed
        float axesValue = Input.GetAxis("Scale"); // This is between -1 and 1 -- a "percent
        // Use that value to calculate a value between -100% and 100% of our max scale per frame
        float scaleAmount = axesValue * maxScale;
        // Increase the scale of our object by that amount on all axes (1, 1, 1) " scaleAmount
        tf.localScale += Vector3.one * scaleAmount; // Vector3.one is the same as a vector with the value (1, 1, 1)
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------    
}
