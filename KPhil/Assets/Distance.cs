﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    public Transform Agent;
    public Transform mt;
    public GameObject me;

    //float dist = Vector3.Distance(Distancetool1.transform.position, Distancetool2.transform.position);

    // Start is called before the first frame update
    void Start()
    {
        // float dist = Vector3.Distance(Distancetool1.position, Distancetool2.position);

    }

    // Update is called once per frame
    void Update()
    {

        //float dist = Vector3.Distance(Distancetool1.transform.position, Distancetool2.transform.position);
        float DtoA = Vector3.Distance(mt.transform.position, Agent.transform.position);

        if((int)DtoA > 5)
        {
            me.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            me.GetComponent<MeshRenderer>().enabled = true;
        }
        
    }
}
