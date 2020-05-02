using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRDecode : MonoBehaviour
{
    public QRCodeDecodeController QRcontroller;
    public GUIStyle gStyle;

    void Start()
    {
        QRcontroller.onQRScanFinished += onScanFinished;
    }

    void OnGUI()
    {
        gStyle.fontSize = (int)((float)(Screen.width) / 15.0f);
        gStyle.alignment = TextAnchor.MiddleCenter;
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height / 10), "");
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 10), "현재 위치 : " + GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().getPoint(), gStyle);

        if (GUI.Button(new Rect(0, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "Reset", gStyle))
        {
            Reset();
        }

        if (GUI.Button(new Rect(Screen.width / 2, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "START", gStyle))
        {
            //SceneManager.LoadScene(1);
            Application.LoadLevel(1);
        }

    }

    void onScanFinished(string str)
    {
        GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().setPoint(str);
    }

    void Reset()
    {
        QRcontroller.Reset();
    }
}
