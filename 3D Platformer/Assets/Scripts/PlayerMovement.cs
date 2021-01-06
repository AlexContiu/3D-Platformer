using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float spd = 1f;
    public Transform player;
    public float mouseSpd = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.fixedDeltaTime * spd, Input.GetAxis("Jump") * Time.fixedDeltaTime * spd, Input.GetAxis("Vertical") * Time.fixedDeltaTime * spd);
        float mouseX = Input.GetAxis("Mouse X") * mouseSpd * Time.fixedDeltaTime;
        player.Rotate(Vector3.up * mouseX);
    }
}
