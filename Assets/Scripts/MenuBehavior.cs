using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour
{
    void die() {
        Application.Quit();
    }

    void start () {
        SceneManager.LoadScene("Game");
    }
}
