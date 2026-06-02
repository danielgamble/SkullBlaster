using System.Threading.Tasks;
using UnityEngine;

public class SkullMover : MonoBehaviour
{
    
    private Transform tf; // The transform component doesn't need to be adjusted by the designer as they can control speeds and whatnot. 
    public float speed; // The speed the player will move throughout the scene independent of frame rate.
    public float rotateSpeed; // The speed the player will rotate.
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;   // Makes transform available to control the player's movements.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveForward() // Lowercase in mover.moveForward
    {
        // GetComponent<Health>().TakeDamage(100); Test if the health component is working correctly
       // Debug.Log("You are moving forward"); 
        tf.position = tf.position + (tf.up * speed * Time.deltaTime); // tf.position moves the sprite locally, speed is selected in Unity interface.
                                                              // Time.deltaTime helps keep the player from moving dramatically fast or slow / glitching on different machines.
    }

    public void moveBackward()
    {
      //  Debug.Log("You are moving Backward");
        // Move backward relative to the transform's up direction:
        tf.position -= tf.up * speed * Time.deltaTime; // -= to move backwards instead of forwards.
    }

    public void rotateClockwise() // How do I tell this to rotate the sprite clockwise.
    {
      //  Debug.Log("You are rotating");
        tf.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime); // rotating the player clockwise.
    }

    public void rotateCounterclockwise() // How do I tell this to rotate the sprite clockwise.
    {
      //  Debug.Log("You are rotating");
        tf.Rotate(0f, 0f, rotateSpeed * Time.deltaTime); // rotating the player counterclockwise
    }

    public void moveRight() // Lowercase m
    {
       // Debug.Log("You teleported right");
        tf.position = tf.position + (Vector3.right); // teleporting a small distance right. 
    }

    public void moveLeft() // Lowercase m
    {
       // Debug.Log("You teleported left");
        tf.position = tf.position - (Vector3.right); // teleporting a small distance left. 
    }

    public void moveUp() // Lowercase m
    {
      //  Debug.Log("You teleported forward");
        tf.position = tf.position + (Vector3.up); // teleporting a small distance forward.
    }

    public void moveDown() // Lowercase m
    {
       // Debug.Log("You teleported backward");
        tf.position = tf.position - (Vector3.up); // - allows the player to telepor opposite of the vector direction.
    }

    public void turbo() // turbo
    {
      //  Debug.Log("Turbo Speed");
        tf.position = tf.position + (tf.up * (speed * 2) * Time.deltaTime); // Setting the speed to double-time when the turbo button is pressed.

    }

    public void Teleport(float xMin,float xMax,float yMin,float yMax) 
    {
        float xSelected = Random.Range(xMin, xMax); // Randomly selecting values for the player to teleport to.
        float ySelected = Random.Range(yMin, yMax);

        // Teleports pawn to a random location within a set range
      //  Debug.Log("Teleports Pawn");
        tf.position = new Vector3(xSelected, ySelected, 0); // Implementing the random numbers for the player to actually teleport.
    }
}
