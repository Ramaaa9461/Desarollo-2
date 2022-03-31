using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_movement : Movement
{

    void Update()
    {
        transform.RotateAround(sun.position, Vector3.one , velocity * Time.deltaTime);
    }
}
