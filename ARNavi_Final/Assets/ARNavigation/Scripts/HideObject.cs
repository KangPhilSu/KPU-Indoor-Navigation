using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{

    public Transform Agent;
    /*public Transform mt;
    public GameObject me;*/

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
        float DtoA = Vector3.Distance(this.transform.position, Agent.transform.position);

        if((int)DtoA > 5)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
        
    }
}
