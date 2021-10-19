using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBox : MonoBehaviour
{
    public bool greenTrigger; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        
       
        
        if(other.CompareTag("ballGreen") && !greenTrigger)
        {
            Debug.Log("Green");

            //Debug.Log(other.name + " Box Triggered");

            greenTrigger = true;
        }
        else greenTrigger = false;
        
    }
}
