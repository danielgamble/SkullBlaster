using UnityEngine;

public class Projectile : Shooter // This is a child of the shooter class
{
    public GameObject projectilePrefab;
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    public override void shoot()
    {

        // Projectile shooting code goes here..
        {
            
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                Debug.Log("Bang!!!");
           

        }

    }
}
