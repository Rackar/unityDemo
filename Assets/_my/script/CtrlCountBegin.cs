using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlCountBegin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
        int t = Random.Range(1, 10);
        print(t);
        for (int i = 0; i < t; i++)
        {
            GameObject eachEnemy = Instantiate(enemy, new Vector3(i - t + t / 2, 6, 0), Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
