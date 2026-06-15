using UnityEngine;

public class CameraUtility : MonoBehaviour
{
    public static float height; // create a float that can be accessed by whatever script we want
    public static float width;

    public static void CalculateDimensions()
    {
        Camera cam = Camera.main; // setting the main camera

        height = 2 * cam.orthographicSize; // making a border the size of the camera no matter what the screen size is.
        width = height * cam.aspect;
    }
}
