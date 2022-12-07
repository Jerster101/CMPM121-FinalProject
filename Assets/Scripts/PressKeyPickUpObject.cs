using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyPickUpObject : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject ThisTrigger;
    public GameObject ObjectOnGround;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
        ThisTrigger.SetActive(true);
        ObjectOnGround.SetActive(true);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
        ThisTrigger.SetActive(false);
    }

}
