using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float velocity = 5;
    [SerializeField] protected Transform sun;


    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position, Vector3.up, velocity * Time.deltaTime);
    }
}
