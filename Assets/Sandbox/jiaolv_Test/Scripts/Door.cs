using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]private float RoomSize = 20f;
    [SerializeField]private CameraController cam;
    public int first = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {
                cam.MoveToNewRoom(RoomSize);
            }
            else
            {
                cam.MoveToNewRoom(-RoomSize);
            }
        }
    }
}
