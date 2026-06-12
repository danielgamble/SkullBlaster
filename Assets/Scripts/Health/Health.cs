using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    // [SerializeField] makes the next line of code's variable available in the inspector even if the variable is set to private.
    // private int test;
    public float maxHealth; // Creating the variable to store max health information.
    public float currentHealth; // This will keep track of health as gameplay progresses.
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        currentHealth = maxHealth; // Sets currentHealth to the value that the designer has maxHealth set to

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log($"HP - {currentHealth}"); // Displays currentHealth value in the console while testing.
    }

    public void Heal(float amount) // A variable to heal the player when we are ready
    {
        currentHealth += amount; // takes the currentHealth value and adds the amount specified.

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // makes sure the currentHealth value can not go below 0 or above the maxHealth value.
    }

    public void TakeDamage(float amount) // A variable to TakeDamage when player is hit
    {
        currentHealth -= amount; // takes the currentHealth value and subtracts the amount specified.


        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // makes sure the currentHealth value can not go below 0 or above the maxHealth value.

        // Lose a life when health = 0
        Death death = GetComponent<Death>(); // Getting the death component so we can destroy the player.
        
        if (death != null & currentHealth <=0 ) // if death is there and the currentHealth is 0 or less than 0, call the Die function and display a message in the console.
        {
            death.Die(); // Calling the die function from the Death script.
            Debug.Log("Though you have been eaten, you will be forever missed."); // A message in the console for when the player is eaten.
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Reload the scene
            SceneManager.LoadScene(currentSceneIndex);

            

        }
    }

    public void Chomped() // A function to kill the player when chomped by the zombie star.
    {
        Death death = GetComponent<Death>(); // Getting the death component so we can destroy the player.

        if (death != null) // if the death component is there...
        {
            death.Die(); // call the death function
            Debug.Log("YA DONE BEEN CHOMPED FOOL!!!"); // tell the player they done been chomped in the console.

            
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Reload the scene
            SceneManager.LoadScene(currentSceneIndex);
          
        }
    }

    void OnTriggerEnter2D(Collider2D other) // Unity specific function that detects a Ridgidbody hitting
                                            // a collider.
    {

        Debug.Log("TakeDamage ");

        Health health = GetComponent<Health>(); // Attaches Health script to allow us to change the value 
                                                // when a collision occurs.

        if (health != null) // if health is there...
        {
            health.TakeDamage(25); // call the chomped function to destroy the player.


            Debug.Log(" -25 HP!!!"); // tell the console that you were chomped.

        }

    }
}
