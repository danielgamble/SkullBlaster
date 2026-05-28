using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Testing if the Quit Button has been pressed (We choose which button this is in the input manager.
        if (Input.GetButtonDown("Quit"))
        {
            // Telling the application to quit when the quit button is pressed.
            Application.Quit();
            // Sending a message to the console that the quit button has been pressed.
            Debug.Log("Quit button pressed");
        }
    }
}
