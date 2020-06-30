using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropdownOption : MonoBehaviour 
{

    public GameObject[] Roomlist;
    public Dropdown myDropdown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (myDropdown.value)
        {
            case 0:
                GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(1);
                break;

            case 1:
                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("201").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("201").GetComponent<ClassRoom>().setSelect(1);
                }


                break;

            case 2:
                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }

                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("202").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("202").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 3:
               
                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }

                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("203").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("203").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 4:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("204").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("204").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 5:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("205").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("205").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 6:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("206").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("206").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 7:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("207").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("207").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 8:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("208").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("208").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 9:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("209").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("209").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 10:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("210").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("210").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 11:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("211").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("211").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 12:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("212").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("212").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 13:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("213").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("213").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 14:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("214").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("214").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 15:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("215").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("215").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 16:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("216").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("216").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 17:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("217").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("217").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 18:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("218").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("218").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 19:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("219").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("219").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 20:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("220").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("220").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 21:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("221").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("221").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 22:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("222").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("222").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 23:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("223").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("223").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 24:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("I-studio").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("I-studio").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 25:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("301").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("301").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 26:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("302").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("302").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 27:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("303").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("303").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 28:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("304").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("304").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 29:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("305").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("305").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 30:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("306").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("306").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 31:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("307").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("307").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 32:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("308").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("308").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 33:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("309").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("309").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 34:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("310").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("310").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 35:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("311").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("311").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 36:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("312").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("312").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 37:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("313").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("313").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 38:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("314").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("314").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 39:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("315").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("315").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 40:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("316").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("316").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 41:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("317").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("317").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 42:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("318").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("318").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 43:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("319").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("319").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 44:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("320").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("320").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 45:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("321").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("321").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 46:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("322").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("322").GetComponent<ClassRoom>().setSelect(1);
                }
                break;

            case 47:

                for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
                {
                    //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                    if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1 | GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
                    {
                        GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);
                        GameObject.Find("SpherePointer").GetComponent<ClassRoom>().setSelect(0);
                    }
                    //선택된 장소를 목적지로 설정
                    if (GameObject.Find("ClassRoom").transform.Find("323").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("323").GetComponent<ClassRoom>().setSelect(1);
                }
                break;
        }
    }
}
