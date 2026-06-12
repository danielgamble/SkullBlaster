using SpaceAdventure.Asset;
using UnityEngine;

public class DeathVolume : MonoBehaviour
{

    public void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.deathVolumeList.Add(this); // add the GameManager instance to the deathVolumeList and access that information
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
    

/*private void OnTriggerEnter2D(Collider2D collision) // calling the collider on trigger
    {
        Death otherDeathComponent = collision.GetComponent<Death>(); // include death component so the zombie star dies when hit

        if (otherDeathComponent != null) // if Death is there....
        {
            otherDeathComponent.Die(); // Call the Die function from the Death script
            Destroy(gameObject); //  destroy the game object on collision
            Debug.Log("The Zombie Star Died"); // a message to check if the code is working correctly
            GameManager.instance.Score++; // calling the game manager when the zombie star dies to add to the score
            
        }
    }*/
}

