using UnityEngine;

public class ProjectileShoot : Shooter
{
    public GameObject projectilePrefab;
    public float shootSpeed = 20;
    // Optional reference to the player transform; if assigned, projectiles will spawn at the player's position.
    public Transform player;
    public float spawnOffset = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<PlayerPawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot()
    {
        
        if (projectilePrefab != null) // checking to make sure the projectile prefab is there.
        {
            Instantiate(projectilePrefab, player.position + player.up * spawnOffset, player.rotation); // spawing the projectile at the player position and setting the offset so it spawns slightly in front of the player.
            //Debug.Log("Bang!!!");

            var mover = projectilePrefab.GetComponent<ProjectileMover>(); // Calling the projectile mover so the bullet doesn't sit still once spawned.
         
            
        }
         
       
    }

    void FixedUpdate()
    {
        
    }

}
