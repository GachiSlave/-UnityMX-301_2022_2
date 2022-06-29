using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Udar : MonoBehaviour
{
    public Rigidbody telo;
    public float m_Thrust = 100f;
    // Start is called before the first frame update
    void Start()
    {
        telo = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            telo.AddForce(transform.right * m_Thrust, ForceMode.Impulse);
        }
    }
}
