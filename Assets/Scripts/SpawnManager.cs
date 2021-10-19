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

    [SerializeField] private int score;


    public
    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator SpawnBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            int indext = Random.Range(0, spawnList.Count);
            Instantiate(spawnList[indext]);
        }

    }


}
