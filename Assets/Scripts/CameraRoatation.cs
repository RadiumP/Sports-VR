using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoatation : MonoBehaviour {

    private Camera cam;
	// Use this for initialization
	void Start () {
        //transform.rotation = Quaternion.Euler(0, 90, 0);//use * to add more degree

       cam = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        float speed = 5.0f;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //Gimbal: using local rotation instead of global
        transform.localRotation *= Quaternion.Euler(0, mouseX * speed, 0); 

        cam.transform.localRotation *= Quaternion.Euler(-mouseY * speed, 0, 0);
    }
}
