using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penzoom : MonoBehaviour
{
    Vector2 prevPos;
    Vector2 nowPos;
    Vector3 movePos;
    float Speed = 5.0f;

    float TouchData;
    Vector2 cur;
    Vector2 Prev;
    public Camera ca;//Main Camera
    void Update()
    {
        if (Input.touchCount == 2)
        {//줌 인 아웃!
            cur = Input.GetTouch(0).position - Input.GetTouch(1).position;
            Prev = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition)
                    - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition));//여기까지는 지금 포스와 전 포스의 거리 차를 구하는 걸로 이해된다.
            TouchData = cur.magnitude - Prev.magnitude;//magnityude는 제곱근을 계산해주는 걸로 알고있다.
            //정확한거는 잘 모르겠으나 줌 이면 1 아웃이면 -1을 리턴을 하는 거 같다. 그래서 이런식으로 하면 줌 인 아웃이 된다.
            ca.transform.Translate(0, 0, TouchData * Time.deltaTime * 0.5f);
        }
    }
}
