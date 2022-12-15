using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bounce : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Vector3 initialVelocity;
    public Rigidbody shell;
    //public static int p2score;
    // Start is called before the first frame update
    void Start()
    {
        //Player 1 gets hit
        
       
        shell  = GetComponent<Rigidbody>();
        Console.Write(shell.velocity);
    }

    // Update is called once per frame
    void Update()
    {

        lastVelocity = shell.velocity;

    }

    //collision enter for ricochet
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            GameObject.Find("Player2").GetComponent<Player>().PlayerTwoScore++;
            PlayerPrefs.SetInt("Score2", GameObject.Find("Player2").GetComponent<Player>().PlayerTwoScore);
            if (GameObject.Find("Player2").GetComponent<Player>().PlayerTwoScore >= 5)
            {
                PlayerPrefs.SetInt("Score2", 0);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.name == "Player2")
        {
            GameObject.Find("Player1").GetComponent<Player>().PlayerOneScore++;
            PlayerPrefs.SetInt("Score1", GameObject.Find("Player1").GetComponent<Player>().PlayerOneScore);
            if (GameObject.Find("Player1").GetComponent<Player>().PlayerOneScore >= 5)
            {
                PlayerPrefs.SetInt("Score1", 0);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



        Ricochet(collision.contacts[0].normal);
        
    }

    void Ricochet(Vector3 collisionNormal)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collisionNormal);

        shell.velocity = direction * Mathf.Max(speed, 10);
    }
}
