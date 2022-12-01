using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 0.0125f;
    //public float rotSpeed = 1000;


    void Update()
    {   
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.03f;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)){
            speed = 0.0125f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }

        //transform.Rotate((0), (Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime), 0, Space.World);
       
     }

}
