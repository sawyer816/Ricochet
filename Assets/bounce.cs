using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bounce : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Vector3 initialVelocity;
    public Rigidbody shell;
    // Start is called before the first frame update
    void Start()
    {
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

            GameObject.Find("Score").GetComponent<TextMeshPro>().text = GameObject.Find("Player2").GetComponent<Player>().PlayerTwoScore.ToString();
        }
        if (collision.gameObject.name == "Player2")
        {
            GameObject.Find("Player1").GetComponent<Player>().PlayerOneScore++;

            GameObject.Find("Score1").GetComponent<TextMeshPro>().text = GameObject.Find("Player1").GetComponent<Player>().PlayerOneScore.ToString();
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
