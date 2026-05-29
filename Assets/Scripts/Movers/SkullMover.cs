using System.Threading.Tasks;
using UnityEngine;

public class SkullMover : MonoBehaviour
{
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        Debug.Log("Moving in a certain direction with mover");
    }
    
    public void Teleport(float xMin,float xMax,float yMin,float yMax)
    {
        float xSelected = Random.Range(xMin, xMax);
        float ySelected = Random.Range(yMin, yMax);

        // Teleports pawn to a random location within a set range
        Debug.Log("Teleports Pawn");
        tf.position = new Vector3(xSelected, ySelected, 0);
    }
}
