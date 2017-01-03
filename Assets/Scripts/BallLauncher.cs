using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {


    public GameObject ballPrefab;
    public float velocity = 5.0f;
    private GameObject ball;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.touchCount == 1)
        {
           if(Input.GetTouch(0).phase == TouchPhase.Began)
           {
                Shoot();
           }
           
        }
    }


    GameObject SpawnBall()
    {

        GameObject ballInstance = Instantiate(ballPrefab); //clone new things
        return ballInstance;
    }

    void Shoot()
    {
        ball = SpawnBall();
        Camera cam = GetComponentInChildren<Camera>();
        ball.transform.position = cam.transform.position;

        ball.GetComponent<Rigidbody>().velocity = cam.transform.rotation * Quaternion.Euler(-30.0f, 0, 0) * Vector3.forward * velocity;

    }

}
