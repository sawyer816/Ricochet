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
    void Awake()
    {
        // create player 1 with keyboard input
        playerOne = Instantiate(TankPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        playerOne.AddComponent<Player>();
        playerOne.GetComponent<Player>().playerOne = true;
        playerOne.GetComponent<Player>().color = Color.blue;
        playerOne.name = "Player1";

        // create player 2 with keyboard input
        playerTwo = Instantiate(TankPrefab, new Vector3(5, 0, 0), Quaternion.identity);
        playerTwo.AddComponent<Player>();
        playerTwo.name = "Player2";

        gameObject.GetComponent<CameraControl>().m_Targets[0] = playerOne.transform;
        gameObject.GetComponent<CameraControl>().m_Targets[1] = playerTwo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
