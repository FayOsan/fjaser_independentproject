using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioClip Collect;
    private PlayerController PC;
    private AudioSource asPlayer;

    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
            gameManager.UpdateScore(1);
            gameManager.AstroidShower();
            other.gameObject.SetActive(false);
            asPlayer.PlayOneShot(Collect, 1);

        }
        else if (other.gameObject.CompareTag("PowerUps"))
        {
            gameManager.UpdateScore(5);
            PC.Dash();
            Destroy(other.gameObject);
        }
    }

}
