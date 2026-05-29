using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
   

    public abstract void MoveForward(); // Capital M matching pawn override

    public abstract void MoveBackward();

    public abstract void RotateClockwise();

    public abstract void RotateCounterclockwise();

    public abstract void MoveUp();

    public abstract void MoveDown();

    public abstract void MoveLeft();

    public abstract void MoveRight();

    public abstract void Turbo();

    public abstract void Teleport();



}
