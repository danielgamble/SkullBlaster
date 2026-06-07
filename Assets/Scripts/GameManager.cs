using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectToSpawn; // giving option to select spawn component in inspector window

    public Transform ZombieSpawnPoint; // giving option to select spawn point for zombie star in inspector window
   
    public List<DeathVolume> deathVolumeList = new List<DeathVolume>(); // this is going to create a new list to keep track of each new deathVolume

    public static GameManager instance; // the static variable can be accessed by everything like a root component.
    
    public void Awake()
    {
        if (instance == null) // if the game manager already exists...
        {
            instance = this; // assigning the game manager as a static variable

            DontDestroyOnLoad(gameObject); // don't destroy game manager on loading to prevent having more than one at a time.
        }

        else
        {
            Destroy(gameObject); // destroy the game manager the new level is trying to create if there is already one populated.
        }


    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (objectToSpawn != null && ZombieSpawnPoint != null) // if the zombieStar and ZombieSpawnPoint exist
        {
            Instantiate(objectToSpawn, ZombieSpawnPoint.position, ZombieSpawnPoint.rotation); // spawn a zombieStar at the selected ZombieSpawnPoint position.
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
