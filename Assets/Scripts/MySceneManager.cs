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
    public Button startButton;
    public Button restartButton;
    public AudioSource backgroundAudio;
    public AudioClip gameOverAudio;
    private AudioSource audioSource;

    public DestroyExtraObjects script;
    private bool flag;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        backgroundAudio.Stop(); 
        script = GameObject.Find("Ground").GetComponent<DestroyExtraObjects>();
        isGameOver = true;

    }

    void Update()
    {
        if (flag && script.isGameOver) GameOver();

    }

    public void GameOver()
    {
        scoreText.gameObject.SetActive(false);
        backgroundAudio.Stop();
        audioSource.PlayOneShot(gameOverAudio, 1.0f);
        restartMenu.gameObject.SetActive(true);
        isGameOver = script.isGameOver;
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
        isGameOver = script.isGameOver;
        flag = true;
    }

}


