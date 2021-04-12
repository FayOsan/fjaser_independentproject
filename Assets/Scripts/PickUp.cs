﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioClip Collect;

    public AudioSource asPlayer;
    // Start is called before the first frame update
    void Start()
    {
        asPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dollar"))
        {
            other.gameObject.SetActive(false);
            asPlayer.PlayOneShot(Collect, 1);
        }
    }
}
