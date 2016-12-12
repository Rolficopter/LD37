using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnBulletCollisionScript : MonoBehaviour {

	public float health;
	public AudioSource hitSound;

	// Use this for initialization
	void Start () {
		health = Random.Range (5, 20);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.CompareTag("Bullet")) {
			hitSound.pitch = Random.Range (0.75f, 1.5f);
			hitSound.Play ();
			col.gameObject.tag = "Untagged";
			health = health - 5;
			if (health <= 0) {
				Destroy (gameObject);
			}
			Destroy (col.gameObject);
			// Play sound.
		}
	}
}
