using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassRoom : MonoBehaviour
{
    // Start is called before the first frame update

    int select;

    public void setSelect(int choose)
    {
        this.select = choose;
    }

    public int getSelect()
    {
        return this.select;
    }

    void Start()
    {
        select = 0;//선택된 강의실과 아닌 강의실의 오브젝트를 구분해서 표시하기위한 변수
    }

    // Update is called once per frame
}
