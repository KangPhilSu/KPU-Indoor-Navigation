using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DropdownOption : MonoBehaviour 
{

    public GameObject classRoom;
    public Dropdown Dropdown;
    public GameObject agent;
    public GameObject RemainText;

    private ClassRoom[] classList;

    // Start is called before the first frame update
    void Start()
    {
        classList = classRoom.GetComponentsInChildren<ClassRoom>();
    }

    void Update()
    {
        dropDown();
    }

    // Update is called once per frame
    public void dropDown()
    {

        if (Dropdown.value == 0)
        {
            RemainText.SetActive(false);
            return;
        }
        else
        {
            int index = Dropdown.value - 1;
            for (int i = 0; i < classList.Length; i++) //목적지로 설정한 곳들을 확인한다.
            {
                //이미 다른 장소가 목적지로 설정됐다면 해당 장소를 초기화
                if (classList[i].getSelect() == 1)
                {
                    classList[i].setSelect(0);
                }
                //선택된 장소를 목적지로 설정
                else if (classList[index].getSelect() == 0)
                    classList[index].setSelect(1);
            }
            agent.GetComponent<ClassRoom>().setSelect(0);
            RemainText.SetActive(true);
        }
    }
}
