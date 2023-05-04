using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float[] heightValues = new float[] {3f,5f, 6f, 7f, 8f, 9f, 10f, 11f, 12f, 13f, 14f};
    private bool[] hasReachedHeights;
    private int currentHeightIndex = -1;


    private void Start()
    {
        hasReachedHeights = new bool[heightValues.Length];
    }

    private void FixedUpdate()
    {
        float currentHeight = transform.position.y;

        // Check if the player has fallen below a height value and reset the flag
        for (int i = 0; i < heightValues.Length; i++)
        {
            if (currentHeight < heightValues[i])
            {
                hasReachedHeights[i] = false;
            }
        }

        // Check if the player has reached a new height value and trigger the rotation
        for (int i = 0; i < heightValues.Length; i++)
        {
            if (!hasReachedHeights[i] && currentHeight >= heightValues[i])
            {
                hasReachedHeights[i] = true;
                currentHeightIndex = i;
                float targetRotationY = i % 2 == 0 ? 270f : 90f; // Alternate between 90 and 270 degrees
                transform.eulerAngles = new Vector3(0f, targetRotationY, 0f);
                break;
            }
        }
    }
}
