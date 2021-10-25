using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public List<GameObject> spawnList;
    [SerializeField] private MySceneManager script;
    public bool isGameOver;
    bool flag;


    public
    void Start()
    {
        script = GameObject.Find("SceneManager").GetComponent<MySceneManager>();

    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = script.isGameOver;

        if (!isGameOver && !flag) CallCondition();


    }

    public IEnumerator SpawnBall()
    {

        while (!isGameOver)
        {
            yield return new WaitForSeconds(1);
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
