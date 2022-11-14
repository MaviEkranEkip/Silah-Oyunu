using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    
    Vector3 direction;
    int y = 0;
    public float speed = 10;
    void Start()
    {
        direction = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        // character jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = new Vector3(0, 1, 0);
            y++;
        }

        // default situation
        else
        {
            direction = new Vector3(0, 0, 0);
        }

        if (y >= 1)
        {
            System.Threading.Thread.Sleep(5000);
            direction = new Vector3(0, 0, 0);
            y--;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }
}
