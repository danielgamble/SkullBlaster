using UnityEngine;

public class ProjectileMover : MonoBehaviour // This is a child of the shooter class
{

    public float shootSpeed;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += transform.up * shootSpeed * Time.fixedDeltaTime; // after shooting, move the projectile forward compared to the players position and rotation.
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

  
}
