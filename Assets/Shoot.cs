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
    // Start is called before the first frame update
    void Start()
    {
        firing = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Player>().playerOne && firing<3)
        {
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Fire();

            }
        }
        if (!gameObject.GetComponent<Player>().playerOne && firing < 3)
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

        // Create an instance of the shell and store a reference to it's rigidbody.
        Rigidbody shellInstance =
            Instantiate(shell, fire.position, fire.rotation) as Rigidbody;
        // Set the shell's velocity to the launch force in the fire position's forward direction.
        shellInstance.velocity = 50 * fire.forward;
    }
}


