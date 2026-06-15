using UnityEngine;

public class EdgeWrap : MonoBehaviour
{
    private void Awake()
    {
        CameraUtility.CalculateDimensions(); // calling teh calculate dimensions function to give us a border.
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 position = transform.position; // telemport the player when going out of border.

        // Left and right
        if (position.x > CameraUtility.width / 2) // if the players position is past either the left or right border, teleport the player through the oposite side.
        {
            position.x = -CameraUtility.width / 2;
        }
        else if (position.x < -CameraUtility.width / 2)
        {
            position.x = CameraUtility.width / 2;
        }
        
        
        // Up and down
        if (position.y > CameraUtility.height / 2) // if the players position is past either the top or bottom border, teleport the player through the oposite side.
        {
            position.y = -CameraUtility.height / 2;
        }
        else if (position.y < -CameraUtility.height / 2)
        {
            position.y = CameraUtility.height / 2;
        }

        transform.position = position;
    }
}
