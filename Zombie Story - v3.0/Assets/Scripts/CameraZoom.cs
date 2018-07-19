using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public Camera myCamera;                 // sets the camera game object
    public float maxZoom;                   // sets the minimum value of the FOV to zoom to
    public float zoomSpeed;                 // sets how fast the camera changes to the minimum FOV

    private float defaultZoom;              // the beginning, default zoom of the camera
    private float targetZoom;               // sets the point where the camera is lerping to and from

	void Start () {
        defaultZoom = myCamera.fieldOfView; // sets the defaultZoom to be the camera's field of view
	}
	
	void Update () {
        if (Input.GetMouseButton(1))
        {
            targetZoom = maxZoom;
        }
        else
        {
            targetZoom = defaultZoom;
        }

        if (myCamera.fieldOfView != targetZoom)
        {
            Debug.Log("zoomin");
            myCamera.fieldOfView = Mathf.Lerp(myCamera.fieldOfView, targetZoom, Time.deltaTime * zoomSpeed);
        }
	}
}
