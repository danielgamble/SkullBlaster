using UnityEngine;

public class PlayerController : Controller // Change parent to Controller
{
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

    // Quit key
    public KeyCode quitKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecisions();
    }

    public override void MakeDecisions()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            Debug.Log("Teleport");
            pawn.Teleport();
        }

        if (Input.GetKey(moveForward))
        {
            Debug.Log("Moving Forward");
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackward))
        {
            Debug.Log("Moving Backward");
            pawn.MoveBackward();
        }

        if (Input.GetKey(rotateClockwise))
        {
            Debug.Log("Rotating Clockwise");
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterclockwise))
        {
            Debug.Log("Rotating Counterclockwise");
            pawn.RotateCounterclockwise();
        }

        if (Input.GetKeyDown(moveUp))
        {
            Debug.Log("Moved Up");
            pawn.MoveUp();
        }

        if (Input.GetKeyDown(moveDown))
        {
            Debug.Log("Moved Down");
            pawn.MoveDown();
        }

        if (Input.GetKeyDown(moveLeft))
        {
            Debug.Log("Moved Left");
            pawn.MoveLeft();
        }

        if (Input.GetKeyDown(moveRight))
        {
            Debug.Log("Moved Right");
            pawn.MoveRight();
        }

        if (Input.GetKey(turbo1) || Input.GetKey(turbo2))
        {
            Debug.Log("Turbo Engaged");
            
        }

        if (Input.GetKeyDown(quitKey))
        {
            Debug.Log("Quit Game");
        }


    }
}
