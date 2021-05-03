﻿using System.Collections;
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
    private Animator LeftArmA;
    private Animator RightArmA;

    public ParticleSystem Dirt;
    private bool DirtPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();
        asPlayer = GetComponent<AudioSource>();

        LeftArmA = GameObject.Find("LeftArmJoint").GetComponent<Animator>();
        RightArmA = GameObject.Find("RightArmJoint").GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * Time.deltaTime * speed * -verticalInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        LeftArmA.SetFloat("Speed", verticalInput);
        RightArmA.SetFloat("Speed", verticalInput);


        if(verticalInput>.01 && !DirtPlaying)
        {
            DirtPlaying = true;
            Dirt.Play();

        }
        else if(verticalInput<.01)
        {
            DirtPlaying = false;
            Dirt.Stop();
        }

        /*if (verticalInput>-.1f)
        {
            Dirt.Play();
        }*/

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

    public void Dash()
    {
        Debug.Log("DASHIE");
    }

}


