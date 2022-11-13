using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playerOne;
    public float Velocity = 500f;
    public Color color;
    public Rigidbody rb;
    public int PlayerOneScore;
    public int PlayerTwoScore;
    // called before first frame
    void Start()
    {
        PlayerOneScore = 0;
        PlayerTwoScore = 0;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // called once per frame
    void FixedUpdate()
    {

        // player one input handling
        if (playerOne)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = transform.forward * Time.deltaTime * Velocity;
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = transform.forward * -1 * Time.deltaTime * Velocity;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -500f * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 500f * Time.deltaTime, 0);
            }
        }

        // player two input handling
        else
        {
            if (Input.GetKey(KeyCode.I))
            {
                rb.velocity = transform.forward * Time.deltaTime * Velocity;
            }
            if (Input.GetKey(KeyCode.K))
            {
                rb.velocity = transform.forward * -1 * Time.deltaTime * Velocity;
            }
            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(0, -500f * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, 500f * Time.deltaTime, 0);

            }
        }
    }
}