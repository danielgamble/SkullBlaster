using GLTFast.Schema;
using UnityEngine;

public class ShootZombie : MonoBehaviour // this is a child of Death
{
    

    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        Debug.Log("You touched the Zombie Star!!! ");

        DeathDestroy deathDestroy = GetComponent<DeathDestroy>();
        //Health health = GetComponent<Health>(); // Attaches Health script to allow us to change the value 
                                                // when a collision occurs.

        if (deathDestroy != null) // if health is there...
        {
            deathDestroy.Die(); // call the chomped function to destroy the player.


            Debug.Log("You shot the Zombie Star!!!"); // tell the console that you were chomped.

        }
        else
        {
            Debug.Log("Poo, I didn't get it."); // if health is not there, display a message that GetComponent failed.
        }
    }


}

