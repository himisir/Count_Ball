using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MySceneManager : MonoBehaviour
{
    public bool isGameOver;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameStartText;
    public GameObject starMenu;
    public GameObject restartMenu;
    public Button easyButton;
    public Button mediumButton;
    public Button hardButton;
    public Button restartButton;
    public AudioSource backgroundAudio;
    public AudioClip gameOverAudio;
    private AudioSource audioSource;

    public DestroyExtraObjects script;
    public GameManager gameManagerScript;

    private bool flag;
    public int difficultyLevel;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        backgroundAudio.Stop();
        script = GameObject.Find("Ground").GetComponent<DestroyExtraObjects>();
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        isGameOver = true;

    }

    void Update()
    {
        if (flag && (script.isGameOver || gameManagerScript.passGameover)) GameOver();

    }

    public void GameOver()
    {
        scoreText.gameObject.SetActive(false);
        backgroundAudio.Stop();
        audioSource.PlayOneShot(gameOverAudio, 1.0f);
        restartMenu.gameObject.SetActive(true);
        isGameOver = true;
        flag = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame()
    {
        backgroundAudio.Play();
        scoreText.gameObject.SetActive(true);
        starMenu.gameObject.SetActive(false);
        isGameOver = false;
        flag = true;
    }
    public void SetDifficulty(int difficulty)
    {
        difficultyLevel = difficulty;
        StartGame();
    }

}


