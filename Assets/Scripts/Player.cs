using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool Player1;
    public float Velocity = 3f;

    // called before first frame
    void Start()
    {
    }

    // called once per frame
    void Update()
    {

        // player input handling
        if (Player1) {
            if (Input.GetKey(KeyCode.W)) {
                transform.Translate(Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.S)) { 
                transform.Translate(-1 * Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.A)) { 
                transform.Rotate(0, -0.5f, 0);
            }
            if (Input.GetKey(KeyCode.D)) {
                transform.Rotate(0, 0.5f, 0);
            }
        }

        // Player 2 input handling
        else {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-1 * Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -0.5f, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0.5f, 0);
            }
        }
    }
        
}

