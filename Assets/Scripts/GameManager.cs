using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //private SpawnManager spawnManager;
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    [SerializeField] private CheckTrigger checkTriggerRed;
    [SerializeField] private CheckTrigger checkTriggerBlue;

    [SerializeField] private CheckTrigger checkTriggerGreen;


    public int finalScore;

    void Start()
    {
        //spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        //scoreText = GetComponent<TextMeshProUGUI>();

        checkTriggerRed = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();
        checkTriggerBlue = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();
        checkTriggerGreen = GameObject.Find("Check Trigger").GetComponent<CheckTrigger>();





        //checkTrigger = FindObjectOfType<CheckTrigger>();

        //Score();

    }

    // Update is called once per frame
    void Update()
    {
        Score();

    }
    void Score()
    {
        finalScore = checkTriggerRed.score + checkTriggerBlue.score + checkTriggerGreen.score;

        Debug.Log(finalScore + " points");

        scoreText.text = "Score: " + finalScore;

    }



}

