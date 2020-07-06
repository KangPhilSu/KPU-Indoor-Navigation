using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show1 : MonoBehaviour
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


    public Transform Agent;

    void Start()
    {

        //info201.SetActive(false);
        //info202.SetActive(false);
        //info203.SetActive(false);
        //info204.SetActive(false);
        //info205.SetActive(false);
        //info206.SetActive(false);
        //info207.SetActive(false);
        //info208.SetActive(false);
        info209.SetActive(false);
        info210.SetActive(false);
        //info211.SetActive(false);
        //info212.SetActive(false);
        //info213.SetActive(false);
        //info214.SetActive(false);
        //info215.SetActive(false);
        //info216.SetActive(false);



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
                //if (hit.transform.tag.Equals("info201"))
                //    {
                //    if (info201.activeInHierarchy == false)
                //    {
                //        info201.SetActive(true);
                //        //var rotation = Quaternion.LookRotation(Agent);

                //        //OB.transform.rotation = rotation;
                //        info201.transform.LookAt(Agent);
                //        //OBT.transform.Rotate(-90, 0, 0);
                //        //OB.transform.rotation = Quaternion.Euler(0, rotationToApplyAroundY, 0);
                //    }
                //    else
                //        info201.SetActive(false);

                //}

                //if (hit.transform.tag.Equals("info202"))
                //    {
                //    if (info202.activeInHierarchy == false)
                //    {
                //        info202.SetActive(true);
                //        //var rotation = Quaternion.LookRotation(Agent);

                //        //OB.transform.rotation = rotation;
                //        info202.transform.LookAt(Agent);
                //        //OBT.transform.Rotate(-90, 0, 0);
                //        //OB.transform.rotation = Quaternion.Euler(0, rotationToApplyAroundY, 0);
                //    }
                //    else
                //        info202.SetActive(false);

                //}

                if (hit.transform.tag.Equals("info209"))
                {
                    if (info209.activeInHierarchy == false)
                    {
                        info209.SetActive(true);
                        //var rotation = Quaternion.LookRotation(Agent);

                        //OB.transform.rotation = rotation;
                        info209.transform.LookAt(Agent);
                        //OBT.transform.Rotate(-90, 0, 0);
                        //OB.transform.rotation = Quaternion.Euler(0, rotationToApplyAroundY, 0);
                    }
                    else
                        info209.SetActive(false);

                }

                else if (hit.transform.tag.Equals("info210"))
                {
                    if (info210.activeInHierarchy == false)
                    {
                        info210.SetActive(true);
                        //var rotation = Quaternion.LookRotation(Agent);

                        //OB.transform.rotation = rotation;
                        info210.transform.LookAt(Agent);
                        //OBT.transform.Rotate(-90, 0, 0);
                        //OB.transform.rotation = Quaternion.Euler(0, rotationToApplyAroundY, 0);
                    }
                    else
                        info210.SetActive(false);

                }
                //if (hit.transform.tag.Equals("info201"))
                //{
                //    if (info201.activeInHierarchy == false)
                //    {
                //        info201.SetActive(true);
                //        //var rotation = Quaternion.LookRotation(Agent);

                //        //OB.transform.rotation = rotation;
                //        info201.transform.LookAt(Agent);
                //        //OBT.transform.Rotate(-90, 0, 0);
                //        //OB.transform.rotation = Quaternion.Euler(0, rotationToApplyAroundY, 0);
                //    }
                //    else
                //        info201.SetActive(false);

                //}




                //if (GameObject.Find("clone") == null)
                //{
                //    GameObject clone = Instantiate(OB, new Vector3(-16.0f, 6.0f, 0.0f), Quaternion.identity);

                //}
                //else
                //{
                //    Destroy(clone);
                //}


            }
        }

    }

}
