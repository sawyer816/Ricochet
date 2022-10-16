using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playerOne;
    public float Velocity = 10f;

    // called before first frame
    void Start()
    {

    }

    // called once per frame
    void Update()
    {
    
        // player one input handling
        if (playerOne) {
            if (Input.GetKey(KeyCode.W)) {
                transform.Translate(Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.S)) { 
                transform.Translate(-1 * Vector3.forward * Time.deltaTime * Velocity);
            }
            if (Input.GetKey(KeyCode.A)) {
                transform.Rotate(0, -500f * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.D)) {
                transform.Rotate(0, 500f *Time.deltaTime, 0);
            }
        }

        // player two input handling
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