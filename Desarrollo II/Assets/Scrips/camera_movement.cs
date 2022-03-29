using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    [SerializeField] Camera cam;
    [Space]
    [SerializeField] Transform[] planets;
    [SerializeField] [Range(0, 9)] int numberPlanet;
    [Space]
    [SerializeField] float speedH;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    Vector3 initialCamPosition;
    Quaternion initialCamRotation;
    bool resetPositionCam;

    Vector3 distanceToPlane;

    float x;
    float y;
    float z;


    void Start()
    {
        initialCamPosition = cam.transform.position;
        initialCamRotation = cam.transform.rotation;
    }
    void Update()
    {

        switch (numberPlanet)
        {
            case 0:




                //Zoom de la camara segun la rueda del mouse

                //Limite -11 y -60
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && cam.transform.position.z < -11f)
                {
                    cam.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + .4f);
                }

                if (Input.GetAxis("Mouse ScrollWheel") < 0 && cam.transform.position.z > - -60f)
                {
                    cam.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .4f);
                }


                if (Input.GetMouseButton(0))
                {
                    if (resetPositionCam)
                    {
                        cam.transform.position = initialCamPosition;
                    }
                    //Rotacion de la camara segun el mouse

                    x += speedH * Input.GetAxis("Mouse X");
                    y -= speedY * Input.GetAxis("Mouse Y");

                    transform.eulerAngles = new Vector3(y, x, 0.0f);

                    resetPositionCam = false;
                }

                break;
            case 1:

                moveCamtoPlanets(0, 1.25f);

                break;
            case 2:

                moveCamtoPlanets(1, 2.5f);

                break;
            case 3:

                moveCamtoPlanets(2, 3.9f);

                break;
            case 4:

                moveCamtoPlanets(3, 2.40f);

                break;
            case 5:

                moveCamtoPlanets(4, 5.72f);

                break;
            case 6:

                moveCamtoPlanets(5, 5.72f);

                break;
            case 7:

                moveCamtoPlanets(6, 3.8f);

                break;
            case 8:

                moveCamtoPlanets(7, 3.8f);

                break;
            case 9:

                moveCamtoPlanets(8, 2.5f);

                break;
        }
    }
    void moveCamtoPlanets(int planet, float offset)
    {
        cam.transform.rotation = initialCamRotation;
        distanceToPlane = new Vector3(0, 0, -offset);
        cam.transform.position = planets[planet].position + distanceToPlane;
        resetPositionCam = true;

    }
   public void nextPlanet()
    {
        numberPlanet++;
        if (numberPlanet == 10)
        {
            numberPlanet = 0;
        }
    }
   public void previousPlanet()
    {
        numberPlanet--;
        if (numberPlanet == -1)
        {
            numberPlanet = 9;
        }
    }
}
