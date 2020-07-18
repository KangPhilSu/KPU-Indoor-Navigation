namespace GoogleARCore.Examples.HelloAR
{
    using System.Collections.Generic;
    using GoogleARCore;
    using GoogleARCore.Examples.Common;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.EventSystems;

#if UNITY_EDITOR
    // Set up touch input propagation while using Instant Preview in the editor.
    using Input = InstantPreviewInput;
#endif

    /// <summary>
    /// Controls the HelloAR example.
    /// </summary>
    public class ARController : MonoBehaviour
    {
        /// <summary>
        /// The rotation in degrees need to apply to prefab when it is placed.
        /// </summary>
        private const float k_PrefabRotation = 180.0f;

        /// <summary>
        /// True if the app is in the process of quitting due to an ARCore connection error,
        /// otherwise false.
        /// </summary>
        private bool m_IsQuitting = false;  //ARCore 연결 오류로 인해 앱이 종료되는 중이면 true 그렇지 않으면 false를 반환하는 bool형 변수 선언

        public Camera FirstPersonCamera;    //ARCamera연동을 위한 변수
        public GameObject CameraTarget;     //ARCamera가 추적하는 물체. 여기서는 맵 상에서 캐릭터의 움직임을 추적한다.
        private Vector3 PrevARPosePosition; //CameraTarget의 이전 위치를 저장하기 위한 Vector3형 변수, 이전 위치와 현재 위치의 차 만큼 CameraTarget의 위치를 이동한다.
        private bool Tracking = false;      //Tracking 상태를 확인하기위한 bool형 변수, 핸드폰의 카메라가 작동하지 않을 경우 bool값이 false

        /// <summary>
        /// The Unity Awake() method.
        /// </summary>
        public void Awake()
        {
            // Enable ARCore to target 60fps camera capture frame rate on supported devices.
            // Note, Application.targetFrameRate is ignored when QualitySettings.vSyncCount != 0.
            Application.targetFrameRate = 140;
        }

        public void Start()
        {
            //set initial position
            PrevARPosePosition = Vector3.zero;    //이전 위치를 어플 시작과 동시에 zero값으로 초기화
        }

        /// <summary>
        /// The Unity Update() method.
        /// </summary>
        public void Update()   //어플리케이션이 실행되고 1프레임마다 update 메소드가 실행되면서 캐릭터의 움직임을 추적한다.
        {
            _UpdateApplicationLifecycle(); //어플리케이션의 생명주기 변경과 관련된 메소드들의 모임

            //move the person indicator according to position
            Vector3 currentARPosition = Frame.Pose.position;    //사용자의 현재 위치를 Vector3자료형으로 저장한다.
            if (!Tracking)
            {
                Tracking = true;
                PrevARPosePosition = Frame.Pose.position;       //만약 사용자가 어플을 처음 시작했을 경우 Tracking 변수의 값을 true로 선언하고 PrevARPosePosition의 값도 사용자의 현재 위치로 저장한다.
            }
            //Remember the previous position so we can apply deltas
            Vector3 deltaPosition = currentARPosition - PrevARPosePosition;     //현재 위치와 이전 위치의 차를 deltaPosition에 저장한다.
            PrevARPosePosition = currentARPosition;             //이전 위치 값을 현재 위치 값으로 저장한다.
            if (CameraTarget != null)
            {
                //The initial forward vector of the sphere must be aligned with the initial camera 
                //direction in the XZ plane.
                //We apply translation only in the XZ plane.
                //구의 초기 벡터 값은 XZ평면의 초기 카메라 방향과 정렬되어야 한다. 여기서 구는 캐릭터를 가리키는 GameObject이다.
                //XZ평면에 대해서만 이동을 설정한다.
                CameraTarget.transform.Translate(deltaPosition.x, deltaPosition.y, deltaPosition.z);   //CameraTarget을 아까 구했던 deltaPosition만큼 이동시킨다. Y값은 XZ평면에서만 이동하므로 0으로 설정한다.
                // Set the pose rotation to be used in the CameraFollow script
                FirstPersonCamera.GetComponent<ArrowDirection>().targetRot = Frame.Pose.rotation;   //회전 값을 적용하기위해 ArrowDirection스크립트로 회전 값을 전달한다.
            }
        }
        

        /// <summary>
        /// Check and update the application lifecycle.
        /// </summary>
        private void _UpdateApplicationLifecycle()    //매 프레임마다 어플리케이션의 생명주기 변동 확인을 위한 메소드
        {
            // Exit the app when the 'back' button is pressed.
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();                             //뒤로가기 키를 누르면 어플리케이션이 종료된다.
            }
            if (Session.Status != SessionStatus.Tracking)
            {
                Screen.sleepTimeout = SleepTimeout.SystemSetting;
            }
            else
            {
                Screen.sleepTimeout = SleepTimeout.NeverSleep;
            }

            if (m_IsQuitting)
            {
                return;
            }
        }

        /// <summary>
        /// Actually quit the application.
        /// </summary>
        private void _DoQuit()
        {
            Application.Quit();
        }
    }
}