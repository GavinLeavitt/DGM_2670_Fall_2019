using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ControlInput : MonoBehaviour
{
    public float speed = 1.0f;
    //private float AxisAngle;
    
    // Update is called once per frame
    void Update()
    {
        //AxisAngle = Vector2.Angle(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // (FIX SO DIAGONAL MOVEMENT IS NOT FASTER THAN HORIZ/VERT)
        transform.Translate(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed, 0);
    }
}
