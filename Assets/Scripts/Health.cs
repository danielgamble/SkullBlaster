using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth; // Creating the variable to store max health information.
    int currentHealth; // This will keep track of health as gameplay progresses.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        currentHealth = maxHealth; // Sets currentHealth to the value that the designer has maxHealth set to

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void ChangeHealth (int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

}
