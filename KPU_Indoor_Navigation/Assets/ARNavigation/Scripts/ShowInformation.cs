using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
    //public GameObject info209;
    //public GameObject info210;
    //public GameObject info211;
    //public GameObject info212;
    //public GameObject info213;
    //public GameObject info214;
    //public GameObject info215;
    //public GameObject info216;
    //public Transform info;

    public GameObject hitObject;
    private ShowInformation[] hitList;

    public Transform infoObject;

    public Transform agentCamera;

    void Start()
    {
        hitList = hitObject.GetComponentsInChildren<ShowInformation>();
    }

    // Update is called once per frame
    void Update()
    {

        //float rotationToApplyAroundY = AgentRot.y + 180.0f;

        if (Input.GetMouseButtonDown(0)) // Input.GetMouseButton(0) , Input.GetTouch(0).phase == TouchPhase.Began
        {
            if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                RaycastHit hit;
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    string hitName = hit.transform.name;

                    //터치 오브젝트와 정보 오브젝트를 결국 같은 개수의 오브젝트가 생길것이다....진짜???
                    //한방 두명씩 들어가는데도 있는데? ㅅㅂ 망했네...가 아니지 한방에 두명이면 그 두명의 정보를
                    //빈오브젝트에 묶어 어차피 부모오브젝트가 활성화 비활성화하면 자식도 같이 되니깐 나님 혹시 천재?

                    int index = Array.BinarySearch(hitList, hitName);

                    if (infoObject.GetChild(index).gameObject.activeInHierarchy == false)
                    {
                        infoObject.GetChild(index).gameObject.SetActive(true);
                        infoObject.GetChild(index).LookAt(agentCamera);
                    }
                    else
                        infoObject.GetChild(index).gameObject.SetActive(false);

                    ////////////////

                    /*if (hit.transform.name.Equals("Hit209"))
                    {
                        /*if (info.GetChild(0).gameObject.activeInHierarchy == false)
                        {
                            info.GetChild(0).gameObject.SetActive(true);
                            info.GetChild(0).transform.LookAt(Agent);
                        }
                        else
                            info.GetChild(0).gameObject.SetActive(false);//

                        if (info209.activeInHierarchy == false)
                        {
                            info209.SetActive(true);
                            info209.transform.LookAt(agentCamera);
                        }
                        else
                            info209.SetActive(false);
                    }

                    if (hit.transform.name.Equals("info210"))
                    {
                        if (info210.activeInHierarchy == false)
                        {
                            info210.SetActive(true);
                            info210.transform.LookAt(agentCamera);
                        }
                        else
                            info210.SetActive(false);
                    }*/
                    ///////////////////////////////////
                }
            }
        }
    }
}
