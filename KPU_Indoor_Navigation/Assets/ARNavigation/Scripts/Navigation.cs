using System.Collections.Generic;
using GoogleARCore;
using GoogleARCore.Examples.Common;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Navigation : MonoBehaviour
{
    private NavMeshAgent agent; //맵 상에서 움직이는 캐릭터를 연동하기 위한 NavMeshAgent 타입의 agent변수 선언

    private NavMeshPath path; //맵 상에서 움직일 수 있는 길을 표현하기 위한 NavMeshPath 타입의 path 변수 선언
    private string fin; //목적이 이름을 저장하기 위한 변수
    private ClassRoom[] classList;
    private String startname = "";
    private bool start = false;

    public Dropdown drop;
    public GameObject classRoom;
    public Transform ARCore;
    public Transform Arrow;
    public GameObject Compass;
    public Text RemainText;
    public GameObject Escape;

    void Start()
    {
        path = new NavMeshPath();  //path 변수에 NavMeshPath객체 선언
        agent = this.GetComponent<NavMeshAgent>(); //agent 변수에 NavMesh컴포넌트를 저장

        //setStartPoint();

        classList = classRoom.GetComponentsInChildren<ClassRoom>();

    }

    void Update()
    {

        for (int k = 0; k < classList.Length; k++)
        {
            if(classList[k].getSelect() == 1)
            {
                agent.destination = classList[k].transform.position;
                Compass.SetActive(true);
                break;
            }
            else if(this.GetComponent<ClassRoom>().getSelect() == 1)
            {
                agent.destination = this.transform.position;
                Compass.SetActive(false);
                break;
            }
        }

        remainDistance();
    }
    
    /// <summary>
    /// 인식한 QR코드 시작점으로 Agent와 ARCore, Arrow의 위치와 방향을 바꾼다. 
    /// </summary>
    void setStartPoint()
    {
        startname = GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().getPoint();
        Transform startpoint = GameObject.Find(startname).transform;

        if (start == false)
        {
            this.transform.position = startpoint.position;
            ARCore.position = new Vector3(startpoint.position.x, (float)1.7, startpoint.position.z);
            Arrow.position = new Vector3(startpoint.position.x, (float)0.1, startpoint.position.z);

            this.transform.rotation = startpoint.rotation;
            ARCore.rotation = startpoint.rotation;
            Arrow.rotation = startpoint.rotation;

            start = true;
        }
    }

    /// <summary>
    /// 목적지 초기화를 할 경우 그려져있던 경로를 지우고 목적지를
    /// 자신으로 초기화해서 경로가 안그려지게한다. 
    /// </summary>
    public void Clear()
    {
        RemainText.gameObject.SetActive(false);
        for (int k = 0; k < classList.Length; k++)  //Roomlist배열의 길이만큼 for문 실행
        {
            classList[k].setSelect(0);
        }
        this.GetComponent<ClassRoom>().setSelect(1);
        drop.SetValueWithoutNotify(0);
        agent.ResetPath();
    }

    /// <summary>
    /// 목적지까지 남은거리를 표시해주며 목적지와 근접하면 경로 탐색을 그만둔다.
    /// </summary>
    public void remainDistance()
    {
        int count = agent.path.corners.Length;
        float remain = 2;

        for (int i = 1; i < count; i++)
        {
            remain += Vector3.Distance(agent.path.corners[i - 1], agent.path.corners[i]);
        }
        Debug.Log("남은 거리 : " + remain);
        RemainText.text = string.Format("남은거리 : {0:0.##}", remain);

        if(remain < 2)
        {
            Clear();
        }
    }
}