using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    public float cam_speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * cam_speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * cam_speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * cam_speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * cam_speed * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            cam_speed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            cam_speed /= 2;
        }

    }
}
