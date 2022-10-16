using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject playerOne;
    public GameObject playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        // create player 1 with keyboard input
        Instantiate(playerOne, new Vector3(0, 0, 0), Quaternion.identity);

        // rigid body
        playerOne.AddComponent<Rigidbody>();
        
        // player settings
        playerOne.AddComponent<Player>();
        playerOne.GetComponent<Player>().Velocity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
