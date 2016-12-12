using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DudeHealthScript : MonoBehaviour {

	public float maxHealth = 50f;
	public float health = 0f;
	public UnityEngine.UI.Text text;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "<3: " + health + "/" + maxHealth;

		if (health <= 0) {
			SceneManager.LoadSceneAsync ("GameOver", LoadSceneMode.Single);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("Enemy")) {
			health -= 5;
			// Play Player Hurt Audio.
		}
	}
}

	