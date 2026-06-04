using UnityEngine;

public class Projectile : Shooter // This is a child of the shooter class
{

    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        
    }

    public override void shoot()
    {
       
        // Projectile shooting code goes here..
    }
}
