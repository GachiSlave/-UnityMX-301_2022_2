using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using System;







public class mathOscilatir : MonoBehaviour

{

    public Vector3 pos;

    public float Amplitude1, Amplitude2;

    public float Omega1, Omega2, Omega3, Phase;

    private float t;

    //[SerializeField] Transform//

    // Start is called before the first frame update

    void Start()

    {

        pos = new Vector3(0, 0, 0);

        Omega1 = 2;

        Omega2 = 1;

        Omega3 = 1;

        Amplitude1 = 10;

        Amplitude2 = 5;

        Phase = 5;

        t = 0;

    }



    // Update is called once per frame

    void Update()

    {

        //pos =pos + new Vector3(3 * Time.deltaTime, 0, 0);

        t = t + Time.deltaTime;

        pos = new Vector3((float)(Amplitude1 * Math.Sin(Omega1 * t + Phase)), 0, (float)(Amplitude2 * Math.Sin(Omega3 * t + Phase)));

        transform.position = pos;

    }

}