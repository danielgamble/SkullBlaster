using UnityEngine;

public class SpawnShroom : MonoBehaviour
{


    private float elapsedTime = 0f; // create a float to keep track of the elapsed play time
    
    public GameObject objectToSpawn; // giving option to select spawn component in inspector window

    public Transform ShroomSpawnPoint; // giving option to select spawn point for zombie star in inspector window
    
    public float TimeToSpawnShroom, SpawnCountdown; // creating a countdown and resetting it so zombie star spawns when timer reaches 0
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCountdown = TimeToSpawnShroom; // when countdown reaches 0, reset TimeToSpawnZombie to variable in inspector.
        elapsedTime = Time.deltaTime; // set elapsedTime to Time.deltaTime which is already keeping track in the background
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        SpawnShroomCollectible(); // call the zombie spawn function

    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    public void SpawnShroomCollectible() // create the spawn zombie function
    {
        
        SpawnCountdown -= Time.deltaTime; // creates a countdown in seconds independent of frame rate
        if (SpawnCountdown <= 0) // if the countdown reaches 0, reset timer and spawn a zombie.
        {
            SpawnCountdown = TimeToSpawnShroom; // reset the timer when it reaches 0
            Instantiate(objectToSpawn, ShroomSpawnPoint.position, ShroomSpawnPoint.rotation); // spawn zombiestar at ZombieSpawnPoint
        }
    }
    
}
