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
                    if (GameObject.Find("ClassRoom").transform.Find("202").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("202").GetComponent<ClassRoom>().setSelect(1);
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
                    if (GameObject.Find("ClassRoom").transform.Find("218").GetComponent<ClassRoom>().getSelect() == 0)
                        GameObject.Find("ClassRoom").transform.Find("218").GetComponent<ClassRoom>().setSelect(1);
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
        }
    }
}
