using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBox : MonoBehaviour
{
    public bool redTrigger; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        
       
        
        if(other.CompareTag("ballRed") && !redTrigger)
        {
            Debug.Log("Red");

            //Debug.Log(other.name + " Box Triggered");


            redTrigger = true;
            
        }
        else redTrigger =false;
    }
}
