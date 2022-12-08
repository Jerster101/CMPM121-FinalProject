using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    const float SPEED = 5f;
    const float SPRINTSPEED = 8f;
    const float GRAVITY = -9.81f;
    //const int MAXSTAMINA = 100;

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;
    //private Coroutine sprint;

    //bool sprinting = false;
    //int currentStamina;
    float x;
    float z;
    CharacterController cc;
    //[SerializeField] Slider staminaBar;
    Vector3 velocity;
    bool isGrounded;

    Transform groundCheck;
    const float GROUNDDISTANCE = 0.4f;
    [SerializeField] LayerMask groundMask;

    void Start()
    {
        //sprint = StartCoroutine(Sprinting());
        cc = GetComponent<CharacterController>();
        groundCheck = gameObject.transform.GetChild(0);

        //currentStamina = MAXSTAMINA;
        //staminaBar.maxValue = MAXSTAMINA;
        //staminaBar.value = MAXSTAMINA;
        //StartCoroutine(Sprinting());
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

        
        if (Input.GetKey(KeyCode.LeftShift) /*&& staminaBar.value >= 0*/)
        {
            cc.Move(move * SPRINTSPEED * Time.deltaTime);
            //sprinting = true;

        }
        else
        {
            cc.Move(move * SPEED * Time.deltaTime);
            //sprinting = false;
        }

        velocity.y += GRAVITY * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }

   /* public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;

            if (regen != null) StopCoroutine(regen);

            regen = StartCoroutine(RegenStamina());
        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);
        while (currentStamina < MAXSTAMINA)
        {
            currentStamina += MAXSTAMINA / 100;
            staminaBar.value = currentStamina;
            yield return regenTick;
        }
        regen = null;
    }

    private IEnumerator Sprinting()
    {

        if (sprinting)
        {

            if (regen != null) StopCoroutine(regen);
            currentStamina -= MAXSTAMINA / 100;
            staminaBar.value = currentStamina;
            yield return regenTick;
        }
        else regen = StartCoroutine(RegenStamina());
    }*/
}