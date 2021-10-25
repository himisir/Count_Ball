using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{    public TextMeshProUGUI scoreText;

    [SerializeField] private CheckTrigger checkTriggerRed;
    [SerializeField] private CheckTrigger checkTriggerBlue;
    [SerializeField] private CheckTrigger checkTriggerGreen;
    [SerializeField] private MySceneManager script;


    public bool isGameOver;
    private int count;
    public int finalScore;

    void Start()
    {
        script = GameObject.Find("SceneManager").GetComponent<MySceneManager>();
    }

    void Update()
    {
        isGameOver = script.isGameOver;
        Score(!isGameOver);
    }
    void Score(bool isGameOver)
    {
        finalScore = checkTriggerRed.score + checkTriggerBlue.score + checkTriggerGreen.score;
        scoreText.text = "Score: " + finalScore;
    }









}

