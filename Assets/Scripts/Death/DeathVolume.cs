using SpaceAdventure.Asset;
using UnityEngine;

public class DeathVolume : MonoBehaviour
{

    public void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.deathVolumeList.Add(this); // add the GameManager instance to the deathVolumeList and access that information
        }
    }
}

