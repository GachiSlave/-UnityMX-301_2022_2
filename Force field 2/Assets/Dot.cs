using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public float R, g, x_0, y_0, z_0, vx_0, vy_0, vz_0, a, b, phi, phi_0, alpha, c, psi, delta, p, e, j;
    public Quaternion q;
    void Start()
    {
        x_0 = transform.position.x;
        y_0 = transform.position.y;
        z_0 = transform.position.z;

        g = 9.8f;
        R = Vector3.Magnitude(new Vector3(x_0, y_0, z_0));

        Vector3 velocity = new Vector3(vx_0, vy_0, vz_0);
        float v_0 = velocity.magnitude;

        float alpha = Mathf.Sin(Vector3.Angle(new Vector3(x_0, y_0, z_0), velocity) * Mathf.PI / 180);
        c = v_0 * alpha * R;
        e = Mathf.Sqrt(1 + ((c * c) / (R * R * R * R * g * g)) * (v_0 * v_0 - 2 * R * g));

        p = c * c / (R * R * g);
        if (v_0 < Mathf.Sqrt(2 * g * R))
        {
            a = p / (1 - e * e);
            b = p / Mathf.Sqrt(1 - e * e);
        }

        if (v_0 > Mathf.Sqrt(2 * g * R))
        {
            a = p / (-1 + e * e);
            b = p / Mathf.Sqrt(-1 + e * e);
        }

        float pc = p / (1 + e);

        phi_0 = Mathf.Atan((c * Mathf.Sqrt(v_0 * v_0 - (c * c) / (R * R))) / (c * c / R - R * R * g));
        if (((c * c / (R * R * R * g) - 1) < 0 && (c / (R * R * g) * Mathf.Sqrt(v_0 * v_0 - c * c / (R * R))) > 0) || ((c * c / (R * R * R * g) - 1) < 0 && (c / (R * R * g) * Mathf.Sqrt(v_0 * v_0 - c * c / (R * R))) < 0))
            phi_0 += Mathf.PI;



        psi = Vector3.Angle(Vector3.right, new Vector3(x_0, y_0, z_0)) * Mathf.PI / 180;
        delta = psi - phi_0;
        q = Quaternion.AngleAxis(delta, Vector3.forward);
        phi = phi_0;
    }

    void Update()
    {
        Vector3 r = new Vector3(Mathf.Cos(delta + phi) * (p / (1 + e * Mathf.Cos(phi))), Mathf.Sin(delta + phi) * (p / (1 + e * Mathf.Cos(phi))), 0);
        transform.position = q * r;
        j = 1 / r.magnitude;
        phi = phi +  5* j * Time.deltaTime;
    }
}
