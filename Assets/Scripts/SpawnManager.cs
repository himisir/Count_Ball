using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public List<GameObject> spawnList;
    [SerializeField] private DestroyExtraObjects script;
    public bool isGameOver;


    public
    void Start()
    {
        script = GameObject.Find("Ground").GetComponent<DestroyExtraObjects>();
        // will be assigned with isGameOver bool variable 
        StartCoroutine(SpawnBall());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnBall()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(1);
            int indext = Random.Range(0, spawnList.Count);
            Instantiate(spawnList[indext]);
            isGameOver = script.isGameOver;
            if(!isGameOver) Debug.Log("Game is over at SpawnManager");


        }

    }


}
