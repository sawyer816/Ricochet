using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Main Camera").GetComponent<Transform>();

        target.Rotate(0, 180, 0, Space.Self);
        transform.LookAt(target);
    }
}
