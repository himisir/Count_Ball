using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExtraObjects : MonoBehaviour
{

    // Start is called before the first frame update

    public ParticleSystem effectRed;
    public ParticleSystem effectGreen;
    public ParticleSystem effectBlue;
    private AudioSource audioSource;

    public AudioClip balloonRed;
    public AudioClip balloonGreen;
    public AudioClip balloonBlue;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Blue"))
        {
            Debug.Log("Blue is now on the ground");
            audioSource.PlayOneShot(balloonBlue, 1.0f);

            Instantiate(effectBlue, collision.transform.position, effectBlue.transform.rotation);


        }
        else if (collision.gameObject.CompareTag("Red"))
        {
            Debug.Log("Red is now on the ground");
            audioSource.PlayOneShot(balloonRed, 1.0f);
            Instantiate(effectRed, collision.transform.position, effectBlue.transform.rotation);

        }
        else if (collision.gameObject.CompareTag("Green"))
        {
            Debug.Log("Green is now on the ground");
            audioSource.PlayOneShot(balloonGreen, 1.0f);
            Instantiate(effectGreen, collision.transform.position, effectBlue.transform.rotation);

        }


        Destroy(collision.gameObject);

    }
}
