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
            Application.targetFrameRate = 60;
        }

        /// <summary>
        /// ���� ��ġ�� ���� ���۰� ���ÿ� zero������ �ʱ�ȭ
        /// </summary>
        public void Start()
        {
            PrevARPosePosition = Vector3.zero;
        }

        public void Update()
        {
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
    }
}