using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        // create player 1 with keyboard input
        p1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p1.AddComponent<Player>();
        p1.GetComponent<Player>().KeyboardInput = true;
        p1.GetComponent<Player>().Velocity = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
