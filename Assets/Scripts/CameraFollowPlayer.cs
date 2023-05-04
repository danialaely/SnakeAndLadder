using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        Vector3 playerPos = playerTransform.position;

        // Calculate the camera's new position based on the player's position
        float offsetX = 0f; // Replace with your desired camera offset
        float offsetY = 0.63f; // Replace with your desired camera offset
        float offsetZ = 0f; // Replace with your desired camera offset
        Vector3 newPos = new Vector3(cameraPos.x + offsetX, playerPos.y + offsetY, cameraPos.z + offsetZ);

        // Move the camera to its new position
        transform.position = newPos;
    }
}
