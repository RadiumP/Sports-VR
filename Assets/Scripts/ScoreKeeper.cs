using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    private int score = 0;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);//save score between scenes
	}
	
	// Update is called once per frame
	void Update () {
       
	}


    public void AddScore(int value)
    {
        score += value;
        print(score);
    }
    public int getScore()
    {
        return score;
    }


   
}
