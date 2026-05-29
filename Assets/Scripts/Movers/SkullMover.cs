using System.Threading.Tasks;
using UnityEngine;

public class SkullMover : MonoBehaviour
{
    
    private Transform tf;
    public float speed;
    public float rotateSpeed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveForward() // Lowercase in mover.moveForward
    {
        Debug.Log("You are moving forward"); 
        tf.position = tf.position + (tf.up * speed * Time.deltaTime); // I created a public float in Pawn.cs for speed but it is not available 
    }

    public void moveBackward()
    {
        Debug.Log("You are moving Backward");
        // Move backward relative to the transform's up direction:
        tf.position -= tf.up * speed * Time.deltaTime;
    }

    public void rotateClockwise() // How do I tell this to rotate the sprite clockwise.
    {
        Debug.Log("You are rotating");
        tf.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
    }

    public void rotateCounterclockwise() // How do I tell this to rotate the sprite clockwise.
    {
        Debug.Log("You are rotating");
        tf.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }

    public void moveRight() // Lowercase m
    {
        Debug.Log("You are moving forward");
        tf.position = tf.position + (Vector3.right); // I created a public float in Pawn.cs for speed but it is not available 
    }

    public void Move() // Not sure how exactly I need to set this up to work properly.
    {
        Debug.Log("You are moving");

    }

    public void Teleport(float xMin,float xMax,float yMin,float yMax)
    {
        float xSelected = Random.Range(xMin, xMax);
        float ySelected = Random.Range(yMin, yMax);

        // Teleports pawn to a random location within a set range
        Debug.Log("Teleports Pawn");
        tf.position = new Vector3(xSelected, ySelected, 0);
    }
}
