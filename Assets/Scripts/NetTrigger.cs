using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetTrigger : MonoBehaviour {

    public int value = 0;
    Collider expectedCollider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
            sk.AddScore(value);
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
        otherCollider.gameObject.tag = "Used";
    }
}
