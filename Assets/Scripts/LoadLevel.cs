using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    [Header("Game Objects")]
    
    public GameObject TankPrefab;
    public GameObject playerOne;
    public GameObject playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        // create player 1 with keyboard input
        playerOne = Instantiate(TankPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        playerOne.AddComponent<Player>();
        playerOne.GetComponent<Player>().playerOne = true;

        // create player 2 with keyboard input
        playerTwo = Instantiate(TankPrefab, new Vector3(5, 0, 0), Quaternion.identity);
        playerTwo.AddComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
