using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeHealthScript : MonoBehaviour {

	public float maxHealth = 100f;
	public float health = 0f;
	public UnityEngine.UI.Text text;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "<3: " + health + "/" + maxHealth;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("Enemy")) {
			health -= 2;
			// Play Player Hurt Audio.
		}
	}
}

	