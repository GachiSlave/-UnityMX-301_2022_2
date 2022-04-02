using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour
{


    [SerializeField] private Rigidbody rb;



    private void FixedUpdate()

    {

        if (Input.GetKeyDown(KeyCode.K))

        {

            rb.AddForce(0, 0, 5, ForceMode.Impulse);

        }

    }


}
