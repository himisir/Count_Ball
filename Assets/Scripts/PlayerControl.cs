using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float turnSpeed;
    [SerializeField] public float yMin = -45;
    [SerializeField] public float yMax = 45;
    [SerializeField] public float xMin = -25;
    [SerializeField] float xMax = 5;




    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Take input form arrow key
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Rotate player 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * (-horizontalInput));
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * verticalInput);

        //limit player rotation on x and y axis; 
        LimitRotation();

    }
    void LimitRotation()
    {
        Vector3 playerEulerAngles = transform.rotation.eulerAngles;
        //set x and y current angle; 
        playerEulerAngles.y = (playerEulerAngles.y > 180) ? playerEulerAngles.y - 360 : playerEulerAngles.y;
        playerEulerAngles.y = Mathf.Clamp(playerEulerAngles.y, yMin, yMax);

        playerEulerAngles.x = (playerEulerAngles.x > 180) ? playerEulerAngles.x - 360 : playerEulerAngles.x;
        playerEulerAngles.x = Mathf.Clamp(playerEulerAngles.x, xMin, xMax);
        playerEulerAngles.z = 0;
        //update the rotation
        transform.rotation = Quaternion.Euler(playerEulerAngles);
    }


}
