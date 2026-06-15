using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    // This is to declare the float data type so we can control the max and min values that our sprite will move to.
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Declaring keyPress publicly so this key can be changed in the Unity interface.
    public KeyCode keyPress;

    // Designer doesn't need access to this part of our variable.
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Making the transform variable available to the spritemover
        tf = transform;
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        // Checking if the key selected in the interface is pressed and setting our selectedX / selectedY to a random variable
        // between the values also determined in the interface.
    if (Input.GetKeyDown(keyPress))
        {
            // Send a message to the console that the Random location key has been pressed
            Debug.Log("Pressing Random Location Key");

            // Declaring selectedX as a float variable and setting it to a random value  between minX and maxX.
            float selectedX = Random.Range(minX, maxX);
            // Declaring selectedY as a float variable and setting it to a random value  between minY and maxX. 
            float selectedY = Random.Range(minY, maxY);

            // Display the value of selectedX and selectedY in the console.
            Debug.Log("Selected X: " + selectedX);
            Debug.Log("Selected Y: " + selectedY);

            // Telling the sprite to move to the randomly selected value when they random location key is pressed.
            tf.position = new Vector3(selectedX, selectedY, 0);
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------    
}
