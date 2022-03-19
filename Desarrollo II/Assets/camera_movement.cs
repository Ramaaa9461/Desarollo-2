using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float velocity;

    [SerializeField] float speedH;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    float x;
    float y;
    float z;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ////Movimiento teniendo en cuenta WASD

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, velocity);
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -velocity);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(velocity, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(-velocity, 0, 0);
        //}




        //Zoom de la camara segun la rueda del mouse

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView += speedZ;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().fieldOfView -= speedZ;
        }

        //Rotacion de la camara segun el mouse

        x += speedH * Input.GetAxis("Mouse X");
        y -= speedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(y, x, 0.0f);
    }
}
