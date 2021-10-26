using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnList;
    [SerializeField] private MySceneManager script;
    public bool isGameOver;
    bool flag;
    void Start()
    {
        script = GameObject.Find("SceneManager").GetComponent<MySceneManager>();
    }
    void Update()
    {
        isGameOver = script.isGameOver;

        if (!isGameOver && !flag) CallCondition();
    }

    public IEnumerator SpawnBall()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(script.difficultyLevel);
            int indext = Random.Range(0, spawnList.Count);
            Instantiate(spawnList[indext]);
        }
    }

    void CallCondition()
    {
        StartCoroutine(SpawnBall());
        Debug.Log("Condition is called");
        flag = true;
    }


}
