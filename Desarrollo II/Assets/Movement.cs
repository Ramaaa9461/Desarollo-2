using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int rotation = 30;
    [SerializeField] float velocity = 5;


    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(rotation * Time.deltaTime, Vector3.up);

        //transform.RotateAround(Vector3.zero, Vector3.right, 5 * Time.deltaTime);
    }
}
