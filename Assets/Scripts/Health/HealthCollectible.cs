using UnityEngine;

public class HealthCollectible :  MonoBehaviour // Attach to player
{
   
    private void OnTriggerEnter2D(Collider2D collision) // cannot be collision2D for triggers
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            Health health = GetComponent<Health>();
            if (health != null)
            {
                health.Heal(10);
            }
            //Destroy(gameObject);

            


        }

       
    }
    
    
   
  
}
