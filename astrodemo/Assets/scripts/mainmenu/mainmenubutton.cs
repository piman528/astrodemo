using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenubutton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("play");
    }
}
