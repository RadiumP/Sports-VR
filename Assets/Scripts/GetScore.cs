using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public int score = 0;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
        if (sk)
        {
            score = sk.getScore();
            Destroy(sk.gameObject);
        }

        scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
