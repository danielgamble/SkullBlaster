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
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
    
}

