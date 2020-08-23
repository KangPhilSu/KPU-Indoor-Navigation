using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAgent : MonoBehaviour
{
    public Transform Agent; //사용자의 캐릭터와 연동하기위한 Sphere

    void Update()
    {
        Vector3 SpherePosition = Agent.position + new Vector3(0, 0.1f, 0);
        this.transform.position = SpherePosition; //사용자가 바라보는 방향을 나타내는 화살표의 방향을 설정
    }
}