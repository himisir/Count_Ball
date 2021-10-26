using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField] private CheckTrigger checkTriggerRed;
    [SerializeField] private CheckTrigger checkTriggerBlue;
    [SerializeField] private CheckTrigger checkTriggerGreen;
    [SerializeField] private MySceneManager script;


    public bool isGameOver;
    private int count;
    public int finalScore;
    public bool passGameover;

    void Start()
    {
        passGameover = false;
        script = GameObject.Find("SceneManager").GetComponent<MySceneManager>();
    }

    void Update()
    {
        PassGameover();
        isGameOver = script.isGameOver;
        Score(!isGameOver);
    }

    void Score(bool isGameOver)
    {
        finalScore = checkTriggerRed.score + checkTriggerBlue.score + checkTriggerGreen.score;
        scoreText.text = "Score: " + finalScore;
    }

    void PassGameover()
    {
        if (checkTriggerRed.isGameOver || checkTriggerGreen.isGameOver || checkTriggerBlue.isGameOver)
        {
            passGameover = true;
        }
    }









}

