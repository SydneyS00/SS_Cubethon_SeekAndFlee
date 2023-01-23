using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Variables
    public Transform player;
    public Vector3 offset; 

    void Update()
    {
        transform.position = player.position + offset; 
    }
}
