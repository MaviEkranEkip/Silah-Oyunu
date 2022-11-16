using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mause_rotation : MonoBehaviour
{
    float lerpTime = 0.004f;
    
    void Update()
    {
        if (Input.GetButton("Fire2")) MausePos();
    }

    void MausePos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 dist = transform.position - mousePos;
        Debug.Log(dist);
        dist.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dist), lerpTime);
    }
}
