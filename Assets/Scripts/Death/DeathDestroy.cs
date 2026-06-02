using GLTFast.Schema;
using UnityEngine;

public class DeathDestroy : Death // this is a child of Death
{
    public override void Die() // creating the Die function to destroy the player.
    {
        Destroy(gameObject); // Parameters unity has given us to destroy the player upon death
    }

    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        Debug.Log("You touched the Zombie Star!!! ");

        Health health = GetComponent<Health>(); // Attaches Health script to allow us to change the value 
                                                // when a collision occurs.

        if (health != null) // if health is there...
        {
            health.Chomped(); // call the chomped function to destroy the player.
            

            Debug.Log("THE ZOMBIE STAR CHOMPED YOUR BRAINS!!!"); // tell the console that you were chomped.
          
        }
        else
        {
            Debug.Log("Poo, I didn't get it."); // if health is not there, display a message that GetComponent failed.
        }
    }

    
}
