using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMPmovewcamera : MonoBehaviour
{

    public Camera mainCamera;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = mainCamera.transform.position + offset;
    }
}
