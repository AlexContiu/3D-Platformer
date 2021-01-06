using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform Player;
    //public Vector3 offset;
    //public float spd = 100f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // transform.position = Player.position + offset;
       // float mouseX = Input.GetAxis("Mouse X");

       // transform.RotateAround(Player.position, new Vector3(0, 1, 0)*mouseX, 1);
    }
}
