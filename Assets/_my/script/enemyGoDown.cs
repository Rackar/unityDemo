using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGoDown : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 4;
    void Start()
    {
        // transform.position = new Vector3(0, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1)
        {
            transform.Translate(Vector3.up * -speed * Time.deltaTime);
        }
        else
        {
            // transform.position = new Vector3(0, 10, 0);
        }
    }
}
