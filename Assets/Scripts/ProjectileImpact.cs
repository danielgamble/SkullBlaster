using UnityEngine;

public class ProjectileImpact : MonoBehaviour
{
    [SerializeField] private AudioClip impactSound;
    [SerializeField] [Range(0f, 1f)] public float volume = 1f;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision) // cannot be collision2D for triggers
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            PlayImpactAudio();

            Destroy(gameObject);

            
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void PlayImpactAudio()
    {
        if (impactSound != null)
        {
            
            AudioSource.PlayClipAtPoint(impactSound, transform.position, volume);
            Debug.Log("Splat");
        }
        else
        {
            Debug.Log("No Splat");
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------    
}
