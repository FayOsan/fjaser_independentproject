using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject astroidPrefab;
    private float spawnRange = 9.5f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private int score = 0;
    public bool gameActive = false;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AstroidShower()
    {
        for (int i =0; i < score; i++)
        {
            Instantiate(astroidPrefab, GenerateAstrodPos(), Quaternion.identity);
        }
    }

    Vector3 GenerateAstrodPos()
    {
        float xPos = Random.Range(-spawnRange, spawnRange);
        float zPos = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(xPos, 21.0f, zPos);
        return spawnPos;
    }

    public void StartGame()
    {
        gameActive = true;
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        gameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }


    public void UpdateScore(int scoreDelta)
    {
        score += scoreDelta;
        scoreText.text = "Score" + score;
    }
    public void ResartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
