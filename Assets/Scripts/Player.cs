using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool primary = true; // player 1 or 2
    public bool KeyboardInput = true; // keyboard input
    public float Velocity = 3f; // default movement speed

    // called before first frame
    void Start()
    {
    }

    // called once per frame
    void Update()
    {

        // player input handling
        if (KeyboardInput) {
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

        // controller input handling
        else {

        }
        
    }
}
