using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGameOver;    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameStartText;
    public GameObject starMenu;
    public GameObject restartMenu;
    public Button startButton;
    public Button restartButton;

    public DestroyExtraObjects script;
    //public SpawnManager spawnScript;
    private bool flag;


    void Start()
    {
        //startButton = GetComponent<Button>();
        //restartButton = GetComponent<Button>();
        script = GameObject.Find("Ground").GetComponent<DestroyExtraObjects>();
        isGameOver = true;

    }

    void Update()
    {
        if (flag && script.isGameOver) GameOver();

    }

    public void GameOver()
    {
        restartMenu.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameOver = script.isGameOver;
        flag = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void StartGame()
    {
        scoreText.gameObject.SetActive(true);
        starMenu.gameObject.SetActive(false);
        isGameOver = script.isGameOver;
        flag = true;
    }

}


