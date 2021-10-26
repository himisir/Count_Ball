using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExtraObjects : MonoBehaviour
{
    public ParticleSystem effectRed;
    public ParticleSystem effectGreen;
    public ParticleSystem effectBlue;
    private AudioSource audioSource;
    public AudioClip balloonRed;
    public AudioClip balloonGreen;
    public AudioClip balloonBlue;
    public bool isGameOver;
    private int count;
    void Start()
    {
        count = 0;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isGameOver)
        {
            if (collision.gameObject.CompareTag("Blue"))
            {
                count++;
                Effects(effectBlue, balloonBlue);
            }
            else if (collision.gameObject.CompareTag("Red"))
            {
                count++;
                Effects(effectRed, balloonRed);
            }
            else if (collision.gameObject.CompareTag("Green"))
            {
                count++;
                Effects(effectGreen, balloonGreen);
            }

            if (count >= 3)
            {
                isGameOver = true;
                //if (isGameOver) Debug.Log("Game is over at DestroyObjects");
            }
            Destroy(collision.gameObject);
        }
        void Effects(ParticleSystem effect, AudioClip clip)
        {
            audioSource.PlayOneShot(clip, 1.0f);
            Instantiate(effect, collision.transform.position, effect.transform.rotation);

        }

    }


}
