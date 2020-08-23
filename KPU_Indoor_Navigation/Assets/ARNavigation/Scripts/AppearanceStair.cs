using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceStair : MonoBehaviour
{
    public GameObject agnet;
    
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        if (agnet.transform.position.y >= this.transform.position.y)
            this.GetComponent<Renderer>().enabled = true;
        else
            this.GetComponent<Renderer>().enabled = false;
    }
}
