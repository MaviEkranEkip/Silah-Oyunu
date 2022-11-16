using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    public Transform Player;
    Vector3 movement;
    void Update()
    {
        transform.position = Player.position;
    }
}
