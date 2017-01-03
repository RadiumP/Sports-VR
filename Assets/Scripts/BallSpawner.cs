using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;
    public float velocity = 5.0f;
    private GameObject ball;
    // Use this for initialization
 
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            ball = SpawnBall();
            ball.transform.position = transform.position;
            ball.GetComponent<Rigidbody>().velocity = Vector3.forward * velocity;
        }
        

    }

    GameObject SpawnBall()
    {

        GameObject ballInstance = Instantiate(ballPrefab); //clone new things
        return ballInstance;
    }
}
