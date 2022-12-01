using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTorch : MonoBehaviour
{
    [SerializeField] GameObject _object;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        bool isOn = _object.activeSelf;
        _object.SetActive(!isOn);
    }
}
