using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mew : MonoBehaviour
{
    public float x_velocity;
    public float y_velocity;
    public float z_velocity;
    public GameObject a, b;
    public float mass = 5;
    public double G, m1, m2;
    Rigidbody m_Rigidbody, m1_Rigidbody, m2_Rigidbody;
    Vector3 pos, pos1, pos2;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m1_Rigidbody = a.GetComponent<Rigidbody>();
        m2_Rigidbody = b.GetComponent<Rigidbody>();
        //m1 = a.GetComponent<float>();
       // m2 = b.GetComponent<float>();

        m_Rigidbody.AddForce(new Vector3(x_velocity, y_velocity, z_velocity) , ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;
        pos1 = a.transform.position;
        pos2 = b.transform.position;
        Vector3 newPos1 = -(pos - pos1);
        Vector3 newPos2 = -(pos - pos2);

        m_Rigidbody.AddForce(newPos1 * (float)( mass * m1 * G / ((pos - pos1).magnitude* (pos - pos1).magnitude* (pos - pos1).magnitude)) + newPos2 * (float)(mass * m2 * G / ((pos - pos2).magnitude * (pos - pos2).magnitude * (pos - pos2).magnitude)));

    }
}
