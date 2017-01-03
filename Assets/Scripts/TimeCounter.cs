using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    LevelManager lvlmng;
    Text time;
	// Use this for initialization
	void Start () {
        lvlmng = FindObjectOfType<LevelManager>();
        time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        time.text = "Time: " + lvlmng.timeTillNextLevel;
	}
}
