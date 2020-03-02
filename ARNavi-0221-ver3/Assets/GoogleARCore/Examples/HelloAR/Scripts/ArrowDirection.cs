using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    public Quaternion targetRot;   //카메라가 회전하는 값을 Quaternion타입으로 받아오기위한 변수
    public GameObject arrow;       //사용자가 바라보는 방향을 가리기는 화살표
    public float rotationSmoothingSpeed = 2.0f;  //화살표가 회전하는 속도 설정
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()    //어플리케이션의 모든 update메소드가 실행된 후에 LateUpdate메소드가 실행되기 때문에 사용자가 회전한 후에 그 값을 받아와 agent를 회전.
    {
        Vector3 targetEulerAngles = targetRot.eulerAngles;     //targetRot의 rotation 값을 저장
        float rotationToApplyAroundY = targetEulerAngles.y;    //rotation값중 y값만 float형으로 저장
        float newCamRotAngleY = Mathf.LerpAngle(arrow.transform.eulerAngles.y,
           rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime); //현재 카메라 회전각과 적용하려는 회전각 사이의 보간. 각도가 360도를 초과할 경우 LerpAngle을 사용하여 처리
        Quaternion newCamRotYQuat = Quaternion.Euler(0, newCamRotAngleY, 0); //회전값을 Quaternion값으로 저장.
        arrow.transform.rotation = newCamRotYQuat; //카메라의 위치를 목표 위치와 동일하게 설정
    }
}
