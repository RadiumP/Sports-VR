using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSounds : MonoBehaviour {

	


    void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponentInChildren<AudioSource>();
        source.Play();
    }

}
