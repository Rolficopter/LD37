using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySoundScript : MonoBehaviour {

	public AudioClip[] sounds;

	private AudioSource audioSource;
	private bool newSoundQueued;

	// Use this for initialization
	void Start () {
		// pre-load a sound
		// this will be the sound for the lifetime of this monster
		this.audioSource = GetComponent<AudioSource> ();
		this.audioSource.clip = sounds [Random.Range (0, sounds.Length)];
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.audioSource.isPlaying && !newSoundQueued) {
			newSoundQueued = true;
			Invoke ("Play", 2);
		}

	}

	void Play() {
		this.audioSource.pitch = Random.value + 0.5f;
		this.audioSource.Play ();
		newSoundQueued = false;
	}
}
