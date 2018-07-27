using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public float soundDelay;            // how long before the clip players
    public AudioSource sound;           // the audio source to be played
    private float timer;                 // float that ticks up on update
    private bool canPlay = false;                // bool that tracks whether you are allowed to play the sound

	// Use this for initialization
	void Start () {
        sound.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime; 
        if (timer >= soundDelay)
            canPlay = true;

        if (canPlay == true)
            sound.enabled = true;
	}
}
