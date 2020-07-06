using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRDecode : MonoBehaviour
{
    public QRCodeDecodeController QRcontroller;
    public GUIStyle gStyle;
    public GameObject start;

    void Start()
    {
        QRcontroller.onQRScanFinished += onScanFinished;
    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.white;
        gStyle.fontSize = (int)((float)(Screen.width) / 15.0f);
        gStyle.alignment = TextAnchor.MiddleCenter;
        gStyle.normal.textColor = Color.white;
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height / 10), "");
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 10), "현재 위치 : " + GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().getPoint(), gStyle);

        if (GUI.Button(new Rect(0, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "Reset", gStyle))
        {
            Reset();
        }

        if (GUI.Button(new Rect(Screen.width / 2, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "START", gStyle))
        {
            //SceneManager.LoadScene(1);
            if(!GameObject.Find("StartPoint").GetComponent<SaveStartPoint>().getPoint().Equals(null))
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

    void update()
    {
        _UpdateApplicationLifecycle();
    }

    private void _UpdateApplicationLifecycle()    //매 프레임마다 어플리케이션의 생명주기 변동 확인을 위한 메소드
    {
        // Exit the app when the 'back' button is pressed.
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();                             //뒤로가기 키를 누르면 어플리케이션이 종료된다.
        }

        // Only allow the screen to sleep when not tracking. Tracking 상태가 아니면 어플리케이션을 절전상태로 바꾼다.
        if (Session.Status != SessionStatus.Tracking)
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
        }
        else
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        // Quit if ARCore was unable to connect and give Unity some time for the toast to
        // appear.
        //if (Session.Status == SessionStatus.ErrorPermissionNotGranted)
        //{
        //    _ShowAndroidToastMessage("Camera permission is needed to run this application.");
        //    m_IsQuitting = true;
        //    Invoke("_DoQuit", 0.5f);
        //}
        //else if (Session.Status.IsError())
        //{
        //    _ShowAndroidToastMessage(
        //        "ARCore encountered a problem connecting.  Please start the app again.");
        //    m_IsQuitting = true;
        //    Invoke("_DoQuit", 0.5f);
        //}
    }

}
