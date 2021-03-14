using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveWallRight", 1, 10);

        InvokeRepeating("MoveWallLeft", 5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveWallRight()
    {
        transform.position = new Vector3(17f, 4.8f, 9.8f);
    }

    void MoveWallLeft()
    {
        transform.position = new Vector3(20f, 4.8f, 9.8f);
    }

}
