using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideRenderer : MonoBehaviour
{

    public Transform Agent;
    public int num;
    private SkinnedMeshRenderer[] a;
    private MeshRenderer[] b;
    /*public Transform mt;
    public GameObject me;*/

    //float dist = Vector3.Distance(Distancetool1.transform.position, Distancetool2.transform.position);

    // Start is called before the first frame update
    void Start()
    {
        a = this.GetComponentsInChildren<SkinnedMeshRenderer>();
        b = this.GetComponentsInChildren<MeshRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {

        //float dist = Vector3.Distance(Distancetool1.transform.position, Distancetool2.transform.position);
        float DtoA = Vector3.Distance(this.transform.position, Agent.transform.position);

        if ((int)DtoA > num)
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i].enabled = false;
            }
            for (int j = 0; j < b.Length; j++)
            {
                b[j].enabled = false;
            }
        }
        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i].enabled = true;
            }
            for (int j = 0; j < b.Length; j++)
            {
                b[j].enabled = true;
            }
        }

        /*if ((int)DtoA > num)
        {
            this.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
        }
        else
        {
            this.GetComponentsInChildren<SkinnedMeshRenderer>().enabled = true;
        }
        Canvas[] canvasObjects = parentObject.GetComponentInChildren<Canvas>();

        foreach (Canvas canvas in canvasObjects)
        {
            canvas.gameobject.enabled = true;
        }*/
    }
}
