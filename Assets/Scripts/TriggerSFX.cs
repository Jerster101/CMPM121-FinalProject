using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    
    [SerializeField] private Vector3 target = new Vector3(450, 5, 450);
    [SerializeField] private float speed = 2;
    public AudioSource playSound;
    public GameObject ThisTrigger;
    public GameObject objectToMove;

    IEnumerator OnTriggerEnter(Collider other)
    {
        playSound.Play();
        objectToMove.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        yield return new WaitForSeconds(1);
        ThisTrigger.SetActive(false);
        Destroy(GameObject.Find("Bear"));
    }

}
