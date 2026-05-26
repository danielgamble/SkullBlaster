using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*  if (Input.GetKey(KeyCode.A))
          {
              Debug.Log("A is down!");
          }

          else
          {
              Debug.Log("A is not down!");
          }

         // this check for left and right input
         float testFloatInput = Input.GetAxis("Scale");

          Debug.Log(testFloatInput);
        */
        // Axis 1: Scale
        // Axis 2: Quit
        Debug.Log("Scale Axis: " + Input.GetAxis("Scale"));
        Debug.Log("Quit Axis: " + Input.GetAxis("Quit"));
    }
}
