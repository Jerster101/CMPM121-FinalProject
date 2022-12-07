using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour
{
    public void die() {
        Application.Quit();
    }

    public void start () {
        SceneManager.LoadScene("Game");
    }
}
