using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float velocity = 5;
    [SerializeField] Transform sun;


    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0,velocity,0) * Time.deltaTime); 
        transform.RotateAround(sun.position, Vector3.up, velocity * Time.deltaTime);
    }
}
