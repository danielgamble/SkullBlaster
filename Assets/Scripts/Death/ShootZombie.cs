using GLTFast.Schema;
using UnityEngine;

public class ShootZombie : MonoBehaviour // this is a child of Death
{
    

    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        

        DeathDestroy deathDestroy = GetComponent<DeathDestroy>();
        //Health health = GetComponent<Health>(); // Attaches Health script to allow us to change the value 
                                                // when a collision occurs.

        if (deathDestroy != null) // if deathDestroy is there...
        {
            deathDestroy.Die(); // call the die function to destroy the zombie.
            GameManager.instance.Score++; // calling the game manager when the zombie star dies to add to the score

            Debug.Log("You shot the Zombie Star!!!"); // tell the console that you shot the zombie star.

            ProjectileImpact projectileImpact = GetComponent<ProjectileImpact>();
            if (projectileImpact != null)
            {
                projectileImpact.PlayImpactAudio();
            }
            

        }
        else
        {
            Debug.Log("Poo, Death is taking a break."); // if death is not there, display a message that GetComponent failed.
        }
    }


}

