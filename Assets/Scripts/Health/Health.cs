using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public float maxHealth; // Creating the variable to store max health information.
    public float currentHealth; // This will keep track of health as gameplay progresses.

    public Slider healthSlider; // create a variable to hold the health slider component.

// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth; // Sets currentHealth to the value that the designer has maxHealth set to



        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth; // Set the max value of the slider to maxHealth
            healthSlider.value = currentHealth; // Set the heath bar value to current HP value
        }
    }

// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth; // Set the health bar value to current HP value
        }

    }

// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void Heal(float amount) // A variable to heal the player when we are ready
    {
        currentHealth += amount; // takes the currentHealth value and adds the amount specified.

        currentHealth =
            Mathf.Clamp(currentHealth, 0,
                maxHealth); // makes sure the currentHealth value can not go below 0 or above the maxHealth value.

        healthSlider.value = currentHealth;
    }

// -----------------------------------------------------------------------------------------------------------------------------------------------
    public void TakeDamage(float amount) // A variable to TakeDamage when player is hit
    {

        currentHealth -= amount; // takes the currentHealth value and subtracts the amount specified.
        currentHealth =
            Mathf.Clamp(currentHealth, 0,
                maxHealth); // makes sure the currentHealth value can not go below 0 or above the maxHealth value.
        Death death = GetComponent<Death>(); // Getting the death component so we can destroy the player.

        if (death != null & currentHealth <= 0 &
            GameManager.instance.Lives >=
            1) // if death is there and the currentHealth is 0 or less than 0, call the Die function and display a message in the console.
        {
            death.Die(); // Calling the die function from the Death script.
            Debug.Log(
                "Though you have been eaten, you will be forever missed."); // A message in the console for when the player is eaten.
            SceneManager.LoadScene(1);

            GameManager.instance.LoseLife();
        }

        if (death != null & GameManager.instance != null)
        {
            if (currentHealth <= 0 & GameManager.instance.Lives <= 0)
            {
                death.Die();
                SceneManager.LoadScene(2);
            }
        }

    }

    // -----------------------------------------------------------------------------------------------------------------------------------------------     


    void OnTriggerEnter2D(Collider2D collision) // cannot be collision2D for triggers
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }
}
