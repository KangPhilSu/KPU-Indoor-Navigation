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
    NavMeshAgent agent; //맵 상에서 움직이는 캐릭터를 연동하기 위한 NavMeshAgent 타입의 agent변수 선언
    private NavMeshPath path; //맵 상에서 움직일 수 있는 길을 표현하기 위한 NavMeshPath 타입의 path 변수 선언
    private bool destinationSet; //목적지 설정이 됐는지 확인하기 위한 bool형 변수 선언
    string fin;                  //목적이 이름을 저장하기 위한 변수
    LineRenderer line;           //맵 상에 경로를 표현하기 위한 LineRenderer타입 변수
    public GameObject[] Roomlist;   //목적지로 설정된 GameObject를 저장하기 위한 배열 선언
    public bool start = false;
    public String startname = "";
    public Dropdown drop;

    void Start()
    {
        path = new NavMeshPath();  //path 변수에 NavMeshPath객체 선언
        agent = GetComponent<NavMeshAgent>(); //agent 변수에 NavMesh컴포넌트를 저장
        line = GetComponent<LineRenderer>();  //line변수에 LineRenderer컴포넌트를 저장
        destinationSet = false;    //초기 목적지 설정 값을 false로 저장
        startname = GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().getPoint();

        if (start == false)
        {
            GameObject.Find(this.gameObject.name).transform.position = GameObject.Find(startname).transform.position;
            GameObject.Find("ARCore Device").transform.position = new Vector3(GameObject.Find(startname).transform.position.x, (float)1.7, GameObject.Find(startname).transform.position.z);
            GameObject.Find("arrow").transform.position = new Vector3(GameObject.Find(startname).transform.position.x, (float)0.1, GameObject.Find(startname).transform.position.z);

            GameObject.Find(this.gameObject.name).transform.rotation = GameObject.Find(startname).transform.rotation;
            GameObject.Find("ARCore Device").transform.rotation = GameObject.Find(startname).transform.rotation;
            //GameObject.Find("arrow").transform.rotation = GameObject.Find(startname).transform.rotation;
            //GameObject.Find("arrow").transform.Rotate(0, GameObject.Find(startname).transform.rotation.y, 0);
            start = true;
        }

    }

    void OnDrawGizmosSelected()    //경로 표시 메소드
    {

        if (agent == null || agent.path == null) //agent 또는 path값이 NULL일 경우 return
            return;

        var line = this.GetComponent<LineRenderer>();  //현재 인스턴스의 LineTenderer 컴포넌트를 var타입의 line변수에 정의
        if (line == null)
        {
            line = this.gameObject.AddComponent<LineRenderer>(); //line이 NULL값일 경우 게임오브젝트에 있는 LineRenderer컴포넌트를 정의
            line.material = new Material(Shader.Find("Sprites/Default")) { color = Color.white };  //line변수의 material값 정의
            line.SetWidth(1f, 1f); 
            line.SetColors(Color.white, Color.cyan); //line 너비 지정 및 색깔 지정
        }

        var path = agent.path;

        line.SetVertexCount(path.corners.Length);  //모서리의 수에 따른 정점 수 설정

        for (int i = 0; i < path.corners.Length; i++)
        {
            line.SetPositions(path.corners);       //경로에 있는 모든 정점 위치 설정
        }


    }

    void Update()                                  //1프레임마다 실행되는 update메소드
    {

        /*if (start == false)
        {
            GameObject.Find(this.gameObject.name).transform.position = GameObject.Find(startname).transform.position;
            GameObject.Find("ARCore Device").transform.position = new Vector3(GameObject.Find(startname).transform.position.x, (float)1.7, GameObject.Find(startname).transform.position.z);
            GameObject.Find("arrow").transform.position = new Vector3(GameObject.Find(startname).transform.position.x, (float)0.1, GameObject.Find(startname).transform.position.z);

            GameObject.Find(this.gameObject.name).transform.rotation = GameObject.Find(startname).transform.rotation;
            GameObject.Find("ARCore Device").transform.rotation = GameObject.Find(startname).transform.rotation;
            //GameObject.Find("arrow").transform.rotation = GameObject.Find(startname).transform.rotation;
            //GameObject.Find("arrow").transform.Rotate(0, GameObject.Find(startname).transform.rotation.y, 0);
            start = true;
        }*/

        GameObject.Find("ARCore Device").transform.position = new Vector3(GameObject.Find("ARCore Device").transform.position.x, GameObject.Find(this.gameObject.name).transform.position.y + (float)1.61, GameObject.Find("ARCore Device").transform.position.z);

        for (int k = 0; k < Roomlist.Length; k++)  //Roomlist배열의 길이만큼 for문 실행
        {
            if (GameObject.Find("ClassRoom").transform.Find(Roomlist[k].gameObject.name).GetComponent<ClassRoom>().getSelect() == 1) //목적지로 설정되어 있는지 확인. ClassRoom컴포넌트의 getSelect()메소드의 값이 1인 GameObject를 찾는다.
            {
                fin = Roomlist[k].gameObject.name; //설정되어 있다면 fin변수에 오브젝트의 이름을 저장
                break;
            }
            else if (GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
            {
                fin = Roomlist[k].gameObject.name;
                break;
            }
        }
        

        //des = GameObject.Find(fin).gameObject;
        agent.destination = GameObject.Find(fin).gameObject.transform.position;  //agent의 목적지값 정의
        OnDrawGizmosSelected();  //경로를 그리는 메소드 실행
    }
    void LateUpdate()
    {
        if (GameObject.Find("SpherePointer").GetComponent<ClassRoom>().getSelect() == 1)
        {
            agent.ResetPath();
            line.SetVertexCount(0);
            line.enabled = false;
        }
    }
    public void Clear()
    {
        drop.SetValueWithoutNotify(0);
        agent.ResetPath();
        line.SetVertexCount(0);
        line.enabled = false;
    }
}