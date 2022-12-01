using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform Target;
    public GameObject Player;
    
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = Target.transform.position;
    }
}
