using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DrawLine : MonoBehaviour
{

    private LineRenderer line;
    public NavMeshAgent agent;
    public Transform compass;

    void Start()
    {
        line = this.GetComponent<LineRenderer>();
    }

    /// <summary>
    /// AR화면과 미니맵 상에서 보여주는 경로 표시의 길이
    /// </summary>
    void Update()
    {
        if (agent == null || agent.path == null) //agent 또는 path값이 NULL일 경우 return
            return;

        if (this.gameObject.layer == 8)
        {
            Vector3 distanceAngle = agent.path.corners[0] - agent.path.corners[1];
            compass.eulerAngles = new Vector3(0, 90 + Mathf.Atan2(distanceAngle.z, distanceAngle.x) * Mathf.Rad2Deg, 0);
            
            /*
            if (agent.path.corners.Length > 1)
            {
                line.positionCount = 2;

                line.SetPosition(0, agent.path.corners[0]);
                line.SetPosition(1, agent.path.corners[1]);
            }
            */
        }
        else if (this.gameObject.layer == 9)
        {
            if (agent.path.corners.Length > 1)
            {
                line.positionCount = agent.path.corners.Length;

                for(int i = 0; i< agent.path.corners.Length; i++)
                {
                    line.SetPosition(i, agent.path.corners[i]);
                }
            }
        }
    }
}
