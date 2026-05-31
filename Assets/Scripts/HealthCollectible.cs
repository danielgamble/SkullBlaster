using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        Debug.Log("You touched the shroom!!! "); 

        PlayerController controller = other.GetComponent<PlayerController>(); // Attaches PlayerController script to allow us to change the value 
                                            // when a collision occurs.

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
            Debug.Log("Gobble Gobble");
        }
        else 
                {
            Debug.Log("Poo, I didn't get it.");
        }

    }

}
