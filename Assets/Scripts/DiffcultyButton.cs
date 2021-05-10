using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffcultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDiffculty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void SetDiffculty()
    {
        gameManager.StartGame();
    }
}
