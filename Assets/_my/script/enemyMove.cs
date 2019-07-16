using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 4;
    void Start()
    {
        transform.position = new Vector3(22, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -22)
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(22, 3, 0);
        }
    }
}
