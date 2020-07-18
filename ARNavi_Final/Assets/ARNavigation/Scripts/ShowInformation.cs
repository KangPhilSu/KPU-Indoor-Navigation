using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInformation : MonoBehaviour
{
    //public GameObject info201;
    //public GameObject info202;
    //public GameObject info203;
    //public GameObject info204;
    //public GameObject info205;
    //public GameObject info206;
    //public GameObject info207;
    //public GameObject info208;
    public GameObject info209;
    public GameObject info210;
    //public GameObject info211;
    //public GameObject info212;
    //public GameObject info213;
    //public GameObject info214;
    //public GameObject info215;
    //public GameObject info216;
    public Transform info;


    public Transform camera;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //float rotationToApplyAroundY = AgentRot.y + 180.0f;

        if (Input.GetMouseButtonDown(0)) // Input.GetMouseButton(0) , Input.GetTouch(0).phase == TouchPhase.Began
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.name.Equals("Hit209"))
                {
                    /*if (info.GetChild(0).gameObject.activeInHierarchy == false)
                    {
                        info.GetChild(0).gameObject.SetActive(true);
                        info.GetChild(0).transform.LookAt(Agent);
                    }
                    else
                        info.GetChild(0).gameObject.SetActive(false);*/

                    if (info209.activeInHierarchy == false)
                    {
                        info209.SetActive(true);
                        info209.transform.LookAt(camera);
                    }
                    else
                        info209.SetActive(false);
                }
            
                if (hit.transform.name.Equals("info210"))
                {
                    if (info210.activeInHierarchy == false)
                    {
                        info210.SetActive(true);
                        info210.transform.LookAt(camera);
                    }
                    else
                        info210.SetActive(false);

                }

            }

        }

    }
    
}
