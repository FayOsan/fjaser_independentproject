using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // forward / backwards movements
    private float speed = 6.0f;
    public float turnSpeed = 1000.0f;

    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(horizontalInput);
        // Car Speed Unspeed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * -verticalInput);
        // Car Rotates
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
