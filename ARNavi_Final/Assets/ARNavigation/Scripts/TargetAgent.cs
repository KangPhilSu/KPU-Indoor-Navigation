using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR : MonoBehaviour
{
    public GameObject Sphere; //사용자의 캐릭터와 연동하기위한 Sphere
    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SpherePosition = Sphere.transform.position + new Vector3(0, 0.1f, 0);
        this.transform.position = SpherePosition; //사용자가 바라보는 방향을 나타내는 화살표의 방향을 설정
    }
}