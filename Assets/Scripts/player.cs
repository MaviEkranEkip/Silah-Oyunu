using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    
    Vector3 direction;
    // Vector3 w, a, s, d;
    // int jump = 0;
    public float speed = 30;
    void Start()
    {
        direction = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        // -- charecter movement --
        /*if (Input.GetKeyDown("w"))
        {
            w = new Vector3(0, 0, 1);
        }*/


        // character jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = new Vector3(0, 2, 0);
            // jump++;
            // System.Threading.Thread.Sleep(5000);
        }
        // default situation
        else 
        {
            direction = new Vector3(0, 0, 0);
        }
        

        /*if (jump >= 1)
        {
            // System.Threading.Thread.Sleep(5000);
            // direction = new Vector3(0, 0, 0);
            jump--;
        }*/
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }
}
