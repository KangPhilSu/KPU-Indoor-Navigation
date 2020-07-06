//-----------------------------------------------------------------------
// <copyright file="HelloARController.cs" company="Google">
//
// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

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
    public class HelloARController : MonoBehaviour
    {
        /// <summary>
        /// The first-person camera being used to render the passthrough camera image (i.e. AR
        /// background).
        /// </summary>
        //public Camera FirstPersonCamera;

        /// <summary>
        /// A prefab to place when a raycast from a user touch hits a vertical plane.
        /// </summary>
        //public GameObject GameObjectVerticalPlanePrefab;

        ///// <summary>
        ///// A prefab to place when a raycast from a user touch hits a horizontal plane.
        ///// </summary>
        //public GameObject GameObjectHorizontalPlanePrefab;

        ///// <summary>
        ///// A prefab to place when a raycast from a user touch hits a feature point.
        ///// </summary>
        //public GameObject GameObjectPointPrefab;

        /// <summary>
        /// The rotation in degrees need to apply to prefab when it is placed.
        /// </summary>
        private const float k_PrefabRotation = 180.0f;

        /// <summary>
        /// True if the app is in the process of quitting due to an ARCore connection error,
        /// otherwise false.
        /// </summary>
        private bool m_IsQuitting = false;  //ARCore ���� ������ ���� ���� ����Ǵ� ���̸� true �׷��� ������ false�� ��ȯ�ϴ� bool�� ���� ����

        public Camera FirstPersonCamera;    //ARCamera������ ���� ����
        public GameObject CameraTarget;     //ARCamera�� �����ϴ� ��ü. ���⼭�� �� �󿡼� ĳ������ �������� �����Ѵ�.
        private Vector3 PrevARPosePosition; //CameraTarget�� ���� ��ġ�� �����ϱ� ���� Vector3�� ����, ���� ��ġ�� ���� ��ġ�� �� ��ŭ CameraTarget�� ��ġ�� �̵��Ѵ�.
        private bool Tracking = false;      //Tracking ���¸� Ȯ���ϱ����� bool�� ����, �ڵ����� ī�޶� �۵����� ���� ��� bool���� false

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
            PrevARPosePosition = Vector3.zero;    //���� ��ġ�� ���� ���۰� ���ÿ� zero������ �ʱ�ȭ
        }

        /// <summary>
        /// The Unity Update() method.
        /// </summary>
        public void Update()   //���ø����̼��� ����ǰ� 1�����Ӹ��� update �޼ҵ尡 ����Ǹ鼭 ĳ������ �������� �����Ѵ�.
        {
            _UpdateApplicationLifecycle(); //���ø����̼��� �����ֱ� ����� ���õ� �޼ҵ���� ����

            //move the person indicator according to position
            Vector3 currentARPosition = Frame.Pose.position;    //������� ���� ��ġ�� Vector3�ڷ������� �����Ѵ�.
            if (!Tracking)
            {
                Tracking = true;
                PrevARPosePosition = Frame.Pose.position;       //���� ����ڰ� ������ ó�� �������� ��� Tracking ������ ���� true�� �����ϰ� PrevARPosePosition�� ���� ������� ���� ��ġ�� �����Ѵ�.
            }
            //Remember the previous position so we can apply deltas
            Vector3 deltaPosition = currentARPosition - PrevARPosePosition;     //���� ��ġ�� ���� ��ġ�� ���� deltaPosition�� �����Ѵ�.
            PrevARPosePosition = currentARPosition;             //���� ��ġ ���� ���� ��ġ ������ �����Ѵ�.
            if (CameraTarget != null)
            {
                //The initial forward vector of the sphere must be aligned with the initial camera 
                //direction in the XZ plane.
                //We apply translation only in the XZ plane.
                //���� �ʱ� ���� ���� XZ����� �ʱ� ī�޶� ����� ���ĵǾ�� �Ѵ�. ���⼭ ���� ĳ���͸� ����Ű�� GameObject�̴�.
                //XZ��鿡 ���ؼ��� �̵��� �����Ѵ�.
                CameraTarget.transform.Translate(deltaPosition.x, deltaPosition.y, deltaPosition.z);   //CameraTarget�� �Ʊ� ���ߴ� deltaPosition��ŭ �̵���Ų��. Y���� XZ��鿡���� �̵��ϹǷ� 0���� �����Ѵ�.
                // Set the pose rotation to be used in the CameraFollow script
                FirstPersonCamera.GetComponent<ArrowDirection>().targetRot = Frame.Pose.rotation;   //ȸ�� ���� �����ϱ����� ArrowDirection��ũ��Ʈ�� ȸ�� ���� �����Ѵ�.
            }
        }
        

        /// <summary>
        /// Check and update the application lifecycle.
        /// </summary>
        private void _UpdateApplicationLifecycle()    //�� �����Ӹ��� ���ø����̼��� �����ֱ� ���� Ȯ���� ���� �޼ҵ�
        {
            // Exit the app when the 'back' button is pressed.
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();                             //�ڷΰ��� Ű�� ������ ���ø����̼��� ����ȴ�.
            }

            // Only allow the screen to sleep when not tracking. Tracking ���°� �ƴϸ� ���ø����̼��� �������·� �ٲ۴�.
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

        /// <summary>
        /// Actually quit the application.
        /// </summary>
        private void _DoQuit()
        {
            Application.Quit();
        }

        /// <summary>
        /// Show an Android toast message.
        /// </summary>
        /// <param name="message">Message string to show in the toast.</param>
        //private void _ShowAndroidToastMessage(string message)
        //{
        //    AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //    AndroidJavaObject unityActivity =
        //        unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        //    if (unityActivity != null)
        //    {
        //        AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
        //        unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
        //        {
        //            AndroidJavaObject toastObject =
        //                toastClass.CallStatic<AndroidJavaObject>(
        //                    "makeText", unityActivity, message, 0);
        //            toastObject.Call("show");
        //        }));
        //    }
        //}
    }
}