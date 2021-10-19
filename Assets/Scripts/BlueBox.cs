using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBox : MonoBehaviour
{
    public bool blueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
       
      
       
        if(other.CompareTag("ballBlue") && !blueTrigger)
        {
            Debug.Log("Blue");
           //Debug.Log(other.name + " Box Triggered");

            blueTrigger = true;
        }
        else blueTrigger = false;
        
    }
}
