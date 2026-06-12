using GLTFast.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathDestroy : Death // this is a child of Death
{
    public override void Die() // creating the Die function to destroy the player.
    {
        Destroy(gameObject); // Parameters unity has given us to destroy the player upon death
                             // Get the index number of the current scene\

        
        

        
    }

  

    
}
