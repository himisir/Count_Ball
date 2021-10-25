using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnGameOver : MonoBehaviour
{
    [SerializeField] private MySceneManager script;
    public bool isGameOver;

    void Start()
    {

        script = GameObject.Find("SceneManager").GetComponent<MySceneManager>();
        isGameOver = script.isGameOver;

    }

    void Update()
    {

        isGameOver = script.isGameOver;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (isGameOver)
        {
            Destroy(other.gameObject);

        }
        isGameOver = script.isGameOver;

    }
    private void OnTriggerStay(Collider other)
    {
        if (isGameOver)
        {
            Destroy(other.gameObject);


        }
        isGameOver = script.isGameOver;

    }
    private void OnTriggerExit(Collider other)
    {
        if (isGameOver)
        {
            Destroy(other.gameObject);
        }
        isGameOver = script.isGameOver;
    }
}
