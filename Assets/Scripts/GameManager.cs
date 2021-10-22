using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    [SerializeField] private CheckTrigger checkTriggerRed;
    [SerializeField] private CheckTrigger checkTriggerBlue;
    [SerializeField] private CheckTrigger checkTriggerGreen;
    [SerializeField] private DestroyExtraObjects script;


    public bool isGameOver;
    private int count;

    public int finalScore;

    void Start()
    {
        script = GameObject.Find("Ground").GetComponent<DestroyExtraObjects>();
        // will be assigned with isGameOver bool variable 
        //checkTriggerRed = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();
        //checkTriggerBlue = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();
        //checkTriggerGreen = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = script.isGameOver;
                if(!isGameOver) Debug.Log("Game is over at GameManager");

        Score(!isGameOver);
    }
    void Score(bool isGameOver)
    {
        finalScore = checkTriggerRed.score + checkTriggerBlue.score + checkTriggerGreen.score;
        scoreText.text = "Score: " + finalScore;
    }



}

