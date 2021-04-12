using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // forward / backwards movements
    private float speed = 6.0f;
    public float turnSpeed = 1000.0f;
    public bool onGround = true;
    private PlayerController playerCtrl;


    private float horizontalInput;
    private float verticalInput;
    public bool gameOver = false;

    public AudioSource asPlayer;
    public AudioClip Catch;

    // Start is called before the first frame update
    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();
        asPlayer = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // Car Speed Unspeed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * -verticalInput);
        // Car Rotates
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Earth"))
        {
            Debug.Log("Game Over!!");
            gameOver = true;
            asPlayer.PlayOneShot(Catch, 1);
            playerCtrl.enabled = false;
        }
    }
}


