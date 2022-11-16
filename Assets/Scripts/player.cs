using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{

    Vector3 direction;
    // Vector3 w;
    // a, s, d;
    // int jump = 0;
    public float speed = 40;
    public float run_speed = 10;
    public float rotationSpeed = 1;
    public float rotation;
    int jump;
    // float rotation_angle;
    void Start()
    {
        direction = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        // -- charecter movement --
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * run_speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            /*if (transform.rotation == )
            {

            }*/
            transform.forward = movementDirection;
            // Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            // transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


        // character jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = new Vector3(0, 2, 0);
            jump++;
            // System.Threading.Thread.Sleep(5000);
        }
        // default situation
        else 
        {
            direction = new Vector3(0, 0, 0);
        }
        

        if (jump >= 1)
        {
            // System.Threading.Thread.Sleep(5000);
            direction = new Vector3(0, 0, 0);
            jump--;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;

        /*movement = w * Time.deltaTime * run_speed;
        transform.position += movement;*/
    }
}
