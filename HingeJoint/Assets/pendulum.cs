using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    private Rigidbody rb;
    public float fi, d, v;

    void Start()
    {
        Vector3 P = new Vector3(d * Mathf.Sin(fi), -d * Mathf.Cos(fi), 0);
        transform.position = P;
        HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;
        hinge.anchor = new Vector3(-d * Mathf.Sin(fi), d * Mathf.Cos(fi), 0);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-v * Mathf.Cos(fi), -v * Mathf.Sin(fi), 0, ForceMode.VelocityChange);
    }
    void Update()
    {

    }
}
