using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float Speed = 5f;
    private Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            
                transform.position = Vector2.MoveTowards(transform.position, player.position, Speed * Time.deltaTime);
            

        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
}
