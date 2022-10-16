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
        Instantiate(p1, new Vector3(0, 0, 0), Quaternion.identity);
        p1.AddComponent<Player>();
        p1.GetComponent<Player>().Player1 = true;
        p1.GetComponent<Player>().Velocity = 3f;

        // create player 2 with keyboard input
        Instantiate(p2, new Vector3(5, 0, 0), Quaternion.identity);
        p2.AddComponent<Player>();
        p2.GetComponent<Player>().Player1 = false;
        p2.GetComponent<Player>().Velocity = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
