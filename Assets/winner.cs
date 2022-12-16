using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winner : MonoBehaviour
{
    public TextMeshProUGUI myText;
    private Color myColor;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = PlayerPrefs.GetString("Winner") + "Wins";
        
        if (PlayerPrefs.GetString("Color") == "red")
        {
            Debug.Log(PlayerPrefs.GetString("Color"));
            myColor = Color.red;
        }
        else
        {
            myColor = Color.blue;
        }
        myText.faceColor = myColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
