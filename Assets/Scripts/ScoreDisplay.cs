using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
        score.text = "Score:  " + sk.getScore();
    }
}
