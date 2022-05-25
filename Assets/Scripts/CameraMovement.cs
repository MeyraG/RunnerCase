using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        // x'te hareket etmemesi icin:
        //transform.position = new Vector3(0f, player.position.y , player.position.z) + offset;
        transform.position = player.position + offset;
    }
    
}