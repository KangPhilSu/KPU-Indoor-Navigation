using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRDecode : MonoBehaviour
{
    public QRCodeDecodeController QRcontroller;
    public SaveStartPoint point;
    public GUIStyle gStyle;

    void Start()
    {
        QRcontroller.onQRScanFinished += onScanFinished;
    }

    /// <summary>
    /// 뒤로가기 키를 누르면 어플리케이션이 종료된다.
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.white;
        gStyle.fontSize = (int)((float)(Screen.width) / 15.0f);
        gStyle.alignment = TextAnchor.MiddleCenter;
        gStyle.normal.textColor = Color.white;
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height / 10), "");
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 10), "현재 위치 : " + point.getPoint(), gStyle);

        if (GUI.Button(new Rect(0, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "Reset", gStyle))
        {
            Reset();
        }

        if (GUI.Button(new Rect(Screen.width / 2, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "START", gStyle))
        {
            //SceneManager.LoadScene(1);
            if (!point.getPoint().Equals(" "))
                SceneManager.LoadScene("ARNavigation");
            return;
        }

    }

    void onScanFinished(string str)
    {
        point.setPoint(str);
    }

    void Reset()
    {
        QRcontroller.Reset();
    }
}
