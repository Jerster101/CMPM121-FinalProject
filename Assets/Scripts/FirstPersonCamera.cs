using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    const float SENSITIVITY = 100f;
    Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        playerBody = transform.parent.GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * SENSITIVITY * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * SENSITIVITY * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        Debug.Log(Input.GetAxis("Mouse Y"));
    }
}