using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody spinRb;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        spinRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 spinVec = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        Vector3 spinVec = new Vector3(Random.Range(-10, 10), 10, 10);
        spinRb.AddTorque(spinVec, ForceMode.Impulse);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.GameOver();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
