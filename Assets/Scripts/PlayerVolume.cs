using UnityEngine;

public class PlayerVolume : MonoBehaviour
{
    public void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.playerVolumeList.Add(this); // add the GameManager instance to the deathVolumeList and access that information
        }

    }

    
}
