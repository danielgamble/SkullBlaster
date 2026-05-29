using UnityEngine;

public class PlayerPawn : Pawn
{
    public SkullMover mover;
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mover = GetComponent<SkullMover>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void MoveForward() // Capital M in Pawn
    {
        if (mover != null)
        {
            mover.moveForward(); // Lowercase m in SkullMover
            
        }
    }

    public override void MoveBackward() // M
    {
        if (mover != null)
        {
            mover.moveBackward(); // m
        }
    }

    public override void RotateClockwise() // Upper Case R
    {
        if (mover != null)
        {
            mover.rotateClockwise(); // lowercase r
        }
    }

    public override void RotateCounterclockwise() // Upper Case R
    {
        if (mover != null)
        {
            mover.rotateCounterclockwise(); // lowercase r
        }
    }

    public override void MoveUp() // M
    {
        if (mover != null)
        {
            mover.Move(); // m
        }
    }

    public override void MoveDown() // M
    {
        if (mover != null)
        {
            mover.Move(); // m
        }
    }

    public override void MoveLeft()
    {
        if (mover != null)
        {
            mover.Move();
        }
    }

    public override void MoveRight()
    {
        if (mover != null)
        {
            mover.moveRight();
        }
    }

    public override void Teleport()
    {
        mover.Teleport(minX, maxX, minY, maxY);
    }
}
