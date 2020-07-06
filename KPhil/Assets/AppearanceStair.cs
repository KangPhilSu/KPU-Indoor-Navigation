using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceStair : MonoBehaviour
{

    public GameObject stair;
    public GameObject agnet;
    // Start is called before the first frame update
    void Start()
    {
        stair.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (agnet.transform.position.y >= stair.transform.position.y)
            stair.GetComponent<Renderer>().enabled = true;
        else
            stair.GetComponent<Renderer>().enabled = false;
    }
}
