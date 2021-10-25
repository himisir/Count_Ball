using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    public int score;
    public bool isTrigger;
    public bool playSound;
    private AudioSource audioSource;
    public AudioClip scoreSound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = 0;
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red") && gameObject.CompareTag("RedBox"))
        {
            isTrigger = true;
        }
        else if (other.gameObject.CompareTag("Blue") && gameObject.CompareTag("BlueBox"))
        {
            isTrigger = true;
        }
        else if (other.gameObject.CompareTag("Green") && gameObject.CompareTag("GreenBox"))
        {
            isTrigger = true;
        }

        if (isTrigger)
        {
            audioSource.PlayOneShot(scoreSound, 1.0f );
            score++;
            isTrigger = false;

        }
       
    }


}
