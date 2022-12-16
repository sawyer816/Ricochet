using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private int firing;
    public Rigidbody shell;
    public Transform fire;
    public bool playerOne;
    public Rigidbody[] SpawnedObjects;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        SpawnedObjects = new Rigidbody[3];
        firing = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.GetComponent<Player>().playerOne)
        {
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Fire();

            }
        }
        if (!gameObject.GetComponent<Player>().playerOne)
        {
            if (Input.GetKeyUp(KeyCode.RightShift))
            {
                Fire();
            }
        }
    }


    private void Fire()
    {
        // keeps track of certain firing rate at a given time.
        firing++;
        if(firing <= 3)
        {
            Rigidbody shellInstance =
           Instantiate(shell, fire.position, fire.rotation) as Rigidbody;
            SpawnedObjects[i % 3] = shellInstance;
            shellInstance.velocity = 50 * fire.forward;
        }
        else
        {
            SpawnedObjects[i % 3].position = fire.position;
            SpawnedObjects[i % 3].rotation = fire.rotation;
            SpawnedObjects[i % 3].velocity = 50 * fire.forward;

        }
        // Create an instance of the shell and store a reference to it's rigidbody.
        
        i = i%3;
        i++;
        
        // Set the shell's velocity to the launch force in the fire position's forward direction.
        
    }
}


