using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    [Header("Game Objects")]
    
    public GameObject TankPrefab;
    public GameObject playerOne;
    public GameObject playerTwo;
    public int player1X, player1Z, player2X, player2Z;

    // Start is called before the first frame update
    void Awake()
    {
        // create player 1 with keyboard input
        playerOne = Instantiate(TankPrefab, new Vector3(player1X, 0, player1Z), Quaternion.identity);
        playerOne.AddComponent<Player>();
        playerOne.GetComponent<Player>().playerOne = true;
       MeshRenderer[] render1 =  playerOne.GetComponentsInChildren<MeshRenderer>();
        for(int i = 0; i < render1.Length; i++)
        {
            render1[i].material.color = Color.red;
        }
        playerOne.name = "Player1";

        // create player 2 with keyboard input
        playerTwo = Instantiate(TankPrefab, new Vector3(player2X, 0, player2Z), Quaternion.identity);
        playerTwo.AddComponent<Player>();
        playerTwo.GetComponent<Player>().playerOne = false;
        MeshRenderer[] render2 = playerTwo.GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < render2.Length; i++)
        {
            render2[i].material.color = Color.blue;
        }
        playerTwo.name = "Player2";

        gameObject.GetComponent<CameraControl>().m_Targets[0] = playerOne.transform;
        gameObject.GetComponent<CameraControl>().m_Targets[1] = playerTwo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
