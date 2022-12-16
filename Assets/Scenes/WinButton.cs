using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{
    public GameObject map;

    void Start()
    {
      
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
