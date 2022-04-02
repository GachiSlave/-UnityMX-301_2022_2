using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using System;

public class SCR : MonoBehaviour
{

    public Vector3 pos;

    public float phi, phi_0, vol, Lenght;

    private float t;

    // Start is called before the first frame update

    void Start()

    {

        Lenght = 5.0f;

        vol = 0;

        t = 0;

        phi_0 = 1.5f;

        pos = new Vector3((float)(Lenght * Math.Sin(phi_0)), (float)(Lenght * Math.Cos(phi_0)), 0);



        // phi_0 = (float) Math.Acos(1 - vol * vol / 2 / 9.81);



    }



    // Update is called once per frame

    void Update()

    {

        t = t + Time.deltaTime;

        //phi = (float) (phi_0*(Math.Sin(Math.Sqrt(9.81/L)) * t + angle));

        phi = (float)(phi_0 * Math.Cos(Math.Sqrt(9.81 / Lenght) * t) + vol * Math.Sqrt(Lenght / 9.81) * Math.Sin(Math.Sqrt(9.81 / Lenght) * t));

        pos = new Vector3((float)(Lenght * Math.Sin(phi)), -(float)(Lenght * Math.Cos(phi)), 0);

        transform.position = pos;

    }

}