using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public Pawn pawn;
    // Defining an abstract method.
    public abstract void MakeDecisions(); // allow us to control the sprite and move around the world.

  
}
