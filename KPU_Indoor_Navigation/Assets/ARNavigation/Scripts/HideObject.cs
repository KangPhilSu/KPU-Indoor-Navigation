using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{

    public Transform Agent;
    public int num;

    // Update is called once per frame
    void Update()
    {

        //float dist = Vector3.Distance(Distancetool1.transform.position, Distancetool2.transform.position);
        float DtoA = Vector3.Distance(this.transform.position, Agent.position);

        if(DtoA > num)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
        
    }
}
