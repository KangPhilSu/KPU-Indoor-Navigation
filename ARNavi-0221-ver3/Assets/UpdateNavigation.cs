using System.Collections.Generic;
using GoogleARCore;
using GoogleARCore.Examples.Common;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpdateNavigation : MonoBehaviour
{
    public GameObject trigger; // collider to change arrows
    public GameObject indicator; // arrow prefab to spawn
    public GameObject arcoreDeviceCam; // ar camera
    public GameObject arrowHelper; // box facing the arrow of person indicator used to calculate spawned AR arrow direction
    public LineRenderer line; // line renderer used to calculate spawned ARarrow direction
    private Anchor anchor; //spawned anchor when putting somthing AR on screen
    private bool hasEntered; //used for onenter collider, make sure it happens only once
    private bool hasExited; //used for onexit collider, make sure it happens only once

    private void Start()
    {
        hasEntered = false;
        hasExited = false;
    }

    private void Update()
    {
        hasEntered = false;
        hasExited = false;
    }

    //what to do when entering a collider
    private void OnTriggerEnter(Collider other)
    {
        //if it is a navTrigger then calculate angle and spawn a new AR arrow
        if (other.name.Equals("NavTrigger(Clone)") && line.positionCount > 0)
        {
            if (hasEntered)
            {
                return;
            }
            hasEntered = true;

            //logic to calculate arrow angle
            Vector2 personPos = new Vector2(this.transform.position.x,
                     this.transform.position.z);
            Vector2 personHelp = new Vector2(arrowHelper.transform.position.x,
                     arrowHelper.transform.position.z);
            Vector3 node3D = line.GetPosition(1);
            Vector2 node2D = new Vector2(node3D.x, node3D.z);

            float angle = Mathf.Rad2Deg * (Mathf.Atan2(personHelp.y - personPos.y,
                     personHelp.x - personPos.x) - Mathf.Atan2(node2D.y - personPos.y,
                     node2D.x - personPos.x));

            // position arrow a bit before the camera and a bit lower
            Vector3 pos = arcoreDeviceCam.transform.position +
                     arcoreDeviceCam.transform.forward * 2 +
                     arcoreDeviceCam.transform.up * -0.5f;

            // rotate arrow a bit
            Quaternion rot = arcoreDeviceCam.transform.rotation *
                     Quaternion.Euler(20, 180, 0);

            // create new anchor
            anchor = Session.CreateAnchor(new Pose(pos, rot));

            //spawn arrow
            GameObject spawned = GameObject.Instantiate(indicator,
                     anchor.transform.position, anchor.transform.rotation,
                     anchor.transform);

            // use calculated angle on spawned arrow
            spawned.transform.Rotate(0, angle, 0, Space.Self);
        }
    }

    //what to do when exiting a collider
    private void OnTriggerExit(Collider other)
    {
        //if it is a navTrigger then delete Anchor and arrow and create a new trigger
        if (other.name.Equals("NavTrigger(Clone)"))
        {
            if (hasExited)
            {
                return;
            }
            hasExited = true;
            Destroy(GameObject.Find("NavTrigger(Clone)"));
            Destroy(GameObject.Find("Anchor"));
            GameObject.Instantiate(trigger, this.transform.position,
                 this.transform.rotation);
        }
    }
}