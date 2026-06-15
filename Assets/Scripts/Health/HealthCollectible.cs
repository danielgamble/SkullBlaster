using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
   

    
    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        Debug.Log("You touched the shroom!!! ");

        Health health = GetComponent<Health>(); // Attaches PlayerController script to allow us to change the value 
                                             // when a collision occurs.

        if (health != null)
        {
            health.Heal(10);
            Destroy(gameObject);
            Debug.Log("Gobble Gobble");
        }
        else 
                {
            Debug.Log("Poo, I didn't get it.");
        }

    }
  
}
