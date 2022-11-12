using System;
using System.Collections;
using System.Collections.Generic;
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
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            Debug.Log("DEAD");
        }
        Console.WriteLine("reached");
        Ricochet(collision.contacts[0].normal);
        
    }

    void Ricochet(Vector3 collisionNormal)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collisionNormal);

        shell.velocity = direction * Mathf.Max(speed, 10);
    }
}
