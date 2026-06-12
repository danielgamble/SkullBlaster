 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // brings in Unity's UI features
using TMPro; // allows us to change the text as the score changes

public class GameManager : MonoBehaviour
{
    public GameObject PlayerToSpawn; // giving option to attach player to spawn point

    public Transform RespawnPoint; // instantiating at the respawn game object designated in the inspector

    public GameObject objectToSpawn; // giving option to select spawn component in inspector window

    public Transform ZombieSpawnPoint; // giving option to select spawn point for zombie star in inspector window
   
    public List<DeathVolume> deathVolumeList = new List<DeathVolume>(); // this is going to create a new list to keep track of each new deathVolume

    public List<PlayerVolume> playerVolumeList = new List<PlayerVolume>();

    public static GameManager instance; // the static variable can be accessed by everything like a root component
    
    
    // Game States

    public GameObject TitleScreenStateObject;
    public GameObject MainMenuStateObject;
    public GameObject OptionsScreenStateObject;
    public GameObject CreditsScreenStateObject;
    public GameObject GamePlayStateObject;
    public GameObject GameOverScreenStateObject;

    // Keep track of time and create score

    private float elapsedTime = 0f; // create a float to keep track of the elapsed play time
    public int Score = 0;
    public TMP_Text scoreText; // TMP_Text is the equivilent of int, float, GameObject, etc. when using to change variables in the inspector
    
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
        ActivateTitleScreen();
       
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.deltaTime; // set elapsedTime to Time.deltaTime which is already keeping track in the background
        //Debug.Log("Elapsed Time: " + elapsedTime);
        scoreText.text = ("Score: " + Score);
    }

    private void DeactivateAllStates()
    {
        // Deactivating all game states
        TitleScreenStateObject.SetActive(false);
        MainMenuStateObject.SetActive(false);
        OptionsScreenStateObject.SetActive(false);
        CreditsScreenStateObject.SetActive(false);
        GamePlayStateObject.SetActive(false);
        GameOverScreenStateObject.SetActive(false);
    }

    public void ActivateTitleScreen()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only title screen to active
        TitleScreenStateObject.SetActive(true);
    }
    
    public void ActivateMainMenu()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only title screen to active
        MainMenuStateObject.SetActive(true);
    }
    
    public void ActivateOptionsScreen()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only options screen to active
        OptionsScreenStateObject.SetActive(true);
    }
    
    public void ActivateCreditsScreen()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only credits screen to active
        CreditsScreenStateObject.SetActive(true);
    }
    
    public void ActivateGamplayScreen()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only game play screen to active
        GamePlayStateObject.SetActive(true);
        
        // Doing anything that is needed to get the game to run
        // Spawning player / enemies / level
    }
    
    public void ActivateGameOverScreen()
    {
        // Deactivate all states
        DeactivateAllStates();
        // Set only game over screen to active
        GameOverScreenStateObject.SetActive(true);
    }

   
    
}
