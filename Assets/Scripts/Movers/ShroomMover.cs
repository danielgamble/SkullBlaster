using UnityEngine;

public class ShroomMover : MonoBehaviour
{
    public float shootSpeed;
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    void FixedUpdate()
    {
        transform.position += transform.up * shootSpeed * Time.fixedDeltaTime; // after shooting, move the projectile forward compared to the players position and rotation.
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {

        
        
    }
}
