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

    public override void MoveForward()
    {
        if (mover != null)
        {
            mover.Move();
            
        }
    }

    public override void MoveBackward()
    {
        if (mover != null)
        {
            mover.Move();
        }
    }

    public override void RotateClockwise()
    {
        if (mover != null)
        {
            mover.Move();
        }
    }

    public override void RotateCounterclockwise()
    {
        if (mover != null)
        {
            mover.Move();
        }
    }

    public override void MoveUp()
    {
        if (mover != null)
        {
            mover.Move();
        }
    }

    public override void MoveDown()
    {
        if (mover != null)
        {
            mover.Move();
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
            mover.Move();
        }
    }

    public override void Teleport()
    {
        mover.Teleport(minX, maxX, minY, maxY);
    }
}
