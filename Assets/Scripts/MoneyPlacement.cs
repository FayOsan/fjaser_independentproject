using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPlacement : MonoBehaviour
{
    public GameObject[] MoneyLocate;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        int Money = Random.Range(0, MoneyLocate.Length);
        Instantiate(prefab, MoneyLocate[Money].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
