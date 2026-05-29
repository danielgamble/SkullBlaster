using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public Pawn pawn;
    // Defining an abstract method.
    public abstract void MakeDecisions();

  
}
