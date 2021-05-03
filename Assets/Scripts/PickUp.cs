using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioClip Collect;
    private PlayerController PC;
    public AudioSource asPlayer;
    // Start is called before the first frame update
    void Start()
    {
        asPlayer = GetComponent<AudioSource>();
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
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
        else if (other.gameObject.CompareTag("PowerUps"))
        {
            PC.Dash();
            Destroy(other.gameObject);
        }
    }

}
