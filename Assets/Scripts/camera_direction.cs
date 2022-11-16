using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_direction : MonoBehaviour
{
    public Transform Player;
    
    void Update()
    {
        transform.rotation = Player.rotation;

    }
}
