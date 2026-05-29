using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float minX; // Defining float variables to call a random number when we want to teleport the pawn to a random location on the screen.
    public float maxX;
    public float minY;
    public float maxY;
   

    public abstract void MoveForward(); // Capital M matching pawn override

    public abstract void MoveBackward(); // M

    public abstract void RotateClockwise(); // R

    public abstract void RotateCounterclockwise(); // R

    public abstract void MoveUp(); // M

    public abstract void MoveDown(); // M

    public abstract void MoveLeft(); // M

    public abstract void MoveRight(); // M

    public abstract void Turbo(); // T

    public abstract void Teleport(); // T



}
