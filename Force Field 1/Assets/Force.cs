using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float M, F, R, impForce;
    public Vector3 pos;
    public Vector3 center;
    public Rigidbody rb, c_rb;
    public GameObject obj, E;

    void Start()
    {
        pos = obj.transform.position;
        Vector3 per = new Vector3(pos.y, -pos.x, 0);
        per = per.normalized * impForce;
        c_rb = E.GetComponent<Rigidbody>();
        M = c_rb.mass;
        center = new Vector3(0, 0, 0);
        F = (float)(M * 6.67418479 * 0.00000001);
        rb.AddForce(per, ForceMode.Impulse);
    }

    void Update()
    {
        pos = obj.transform.position;
        R = pos.magnitude;
        pos = (pos.normalized * F) / (R * R);
        rb.AddForce(-pos, ForceMode.Force);
    }
}
