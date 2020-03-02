using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject[] Roomlist;

    public void Onclick()
    {
        for (int i = 0; i < Roomlist.Length; i++) //목적지로 설정한 곳들을 확인한다.
        {
            //이미 다른 장소가 목적지로 설정됬다면 해당 장소를 초기화
            if (GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1)
                GameObject.Find("ClassRoom").transform.Find(Roomlist[i].gameObject.name).GetComponent<ClassRoom>().setSelect(0);

            //선택된 장소를 목적지로 설정
            if (GameObject.Find("ClassRoom").transform.Find(this.gameObject.name).GetComponent<ClassRoom>().getSelect() == 0)
                GameObject.Find("ClassRoom").transform.Find(this.gameObject.name).GetComponent<ClassRoom>().setSelect(1);
        }
    }

}