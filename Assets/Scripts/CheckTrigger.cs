using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    public int score;
    public bool isTrigger;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red") && gameObject.CompareTag("RedBox"))
        {
            Debug.Log(gameObject.name + " is triggered");
            isTrigger = true;
        }
        else if (other.gameObject.CompareTag("Blue") && gameObject.CompareTag("BlueBox"))
        {
            Debug.Log(gameObject.name + " is triggered");
            isTrigger = true;
        }
        else if (other.gameObject.CompareTag("Green") && gameObject.CompareTag("GreenBox"))
        {
            Debug.Log(gameObject.name + " is triggered");
            isTrigger = true;
        }
        
        if (isTrigger){
             score++;
             isTrigger = false;

        }
    }


}
