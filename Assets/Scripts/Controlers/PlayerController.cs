using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Controller // Change parent to Controller
{

 

    // This is where we will make the button selection available inside the Unity interface for each player movement.
    // Using KeyCode is what allows the button to be selected.

    // Teleport Key
    public KeyCode teleportKey; // T

    // Local Space Movement Keys
    public KeyCode moveForward; // W
    public KeyCode moveBackward; // S
    public KeyCode rotateClockwise; //
    public KeyCode rotateCounterclockwise; // 

    // World Space Movement Keys
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    // Turbo Speed Keys
    public KeyCode turbo1;
    public KeyCode turbo2;

    // Fire Key
    public KeyCode shoot;

    // Quit key
    public KeyCode quitKey;

    private Rigidbody2D rb; // declaring the rigidbody2D variable

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      //currentHealth = maxHealth; // Sets currentHealth to the value that the designer has maxHealth set to

        rb = GetComponent<Rigidbody2D>(); // Getting access to the Rigidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecisions(); // This is calling the MakeDecisions function each frame to keep it going while the game is open.
    }

    void FixedUpdate()
    {

    }

    

    public override void MakeDecisions()
    {
        if (Input.GetKeyDown(teleportKey)) // Checking if the teleport key is pressed.
        {
           // Debug.Log("Teleport"); // Tell the console the teleport button has been pressed.
            pawn.Teleport(); // Tells the player to execute the teleport function defined in SkullMover.cs
        }

        if (Input.GetKey(moveForward)) // Checking if the moveForward key is down.
        {
           // Debug.Log("Moving Forward");
            pawn.MoveForward(); // Tells the player to execute the MoveForward function defined in SkullMover.cs
        }

        if (Input.GetKey(moveBackward))
        {
           // Debug.Log("Moving Backward");
            pawn.MoveBackward();
        }

        if (Input.GetKey(rotateClockwise))
        {
           // Debug.Log("Rotating Clockwise");
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterclockwise))
        {
           // Debug.Log("Rotating Counterclockwise");
            pawn.RotateCounterclockwise();
        }

        if (Input.GetKeyDown(moveUp))
        {
           // Debug.Log("Moved Up");
            pawn.MoveUp();
        }

        if (Input.GetKeyDown(moveDown))
        {
           // Debug.Log("Moved Down");
            pawn.MoveDown();
        }

        if (Input.GetKeyDown(moveLeft))
        {
           // Debug.Log("Moved Left");
            pawn.MoveLeft();
        }

        if (Input.GetKeyDown(moveRight))
        {
           // Debug.Log("Moved Right");
            pawn.MoveRight();
        }

        if (Input.GetKey(turbo1) || Input.GetKey(turbo2))
        {
           // Debug.Log("Turbo Engaged");
            pawn.Turbo();
            
        }

        if (Input.GetKeyDown(quitKey))
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }

        if (Input.GetKeyDown(shoot))
        {
            Projectile projectile = GetComponent<Projectile>();
            if (projectile != null)
            {
                Debug.Log("Shot Fired!!!");
                projectile.shoot();
            }

            else
            {
                Debug.Log("Couldn't get shooter");
            }
           
        }


    }
}
