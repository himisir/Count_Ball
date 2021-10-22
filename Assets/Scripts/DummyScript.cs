using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGameOver; 
    private DestroyExtraObjects gameOverSwitch; 
    void Start()
    {
        isGameOver = gameOverSwitch.isGameOver;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver) Debug.Log("Game is Over"); 
        
    }
}
