using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform RobotKyle;
    public Vector3 offset = new Vector3(5f, 1f, 0f);

    // Updates the camera position to follow RobotKyle with a fixed offset
    void Update()
    {
        transform.position = RobotKyle.position + offset;
    }
}
