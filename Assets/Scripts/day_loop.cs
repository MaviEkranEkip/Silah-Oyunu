using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_loop : MonoBehaviour
{

    float turnSpeed = 0.7f; 
    int x = 11;
    void Update()
    {
        // day loop
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(x, 0, 0), turnSpeed * Time.deltaTime);
        if (transform.rotation == Quaternion.Euler(x, 0, 0))
        {
            x += 1;
        }

        if (transform.rotation == Quaternion.Euler(361, 0, 0))
        {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                x = 1;
        }
    }

}
