using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    float x;
    float z;
    CharacterController cc;
    const float SPEED = 5f;
    const float SPRINTSPEED = 8f;
    const float GRAVITY = -9.81f;
    Vector3 velocity;
    bool isGrounded;

    Transform groundCheck;
    const float GROUNDDISTANCE = 0.4f;
    [SerializeField] LayerMask groundMask;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        groundCheck = gameObject.transform.GetChild(0);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, GROUNDDISTANCE, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cc.Move(move * SPRINTSPEED * Time.deltaTime);
        }
        else
        {
            cc.Move(move * SPEED * Time.deltaTime);
        }

        velocity.y += GRAVITY * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }
}