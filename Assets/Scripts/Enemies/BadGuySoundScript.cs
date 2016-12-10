using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySoundScript : MonoBehaviour {

	public AudioClip[] sounds;

	bool newSoundQueued;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource audioSource = GetComponent<AudioSource> ();

		if (!audioSource.isPlaying && !newSoundQueued) {
			audioSource.clip = sounds [Random.Range (0, sounds.Length)];
			newSoundQueued = true;
			Invoke ("Play", 2);
		}

	}

	void Play() {
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.pitch = Random.value + 0.5f;
		audioSource.Play ();
		newSoundQueued = false;
	}
}
