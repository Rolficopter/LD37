using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTestLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(NextLevel("Level2", 3));
		StartCoroutine(NextLevel("Level3", 6));
		StartCoroutine(NextLevel("Level4", 9));
		StartCoroutine (GameOver ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator NextLevel(string name, float delay) {
		yield return new WaitForSeconds (delay);

		var objectsToRemove = GameObject.FindGameObjectsWithTag ("RemoveFor_" + name);
		foreach (var obj in objectsToRemove) {
			DestroyObject (obj);
		}
			
		GameObject.Find ("LevelChangedSound").GetComponent<AudioSource> ().Play ();
	}

	IEnumerator GameOver() {
		yield return new WaitForSeconds (13);
		GameObject.Find ("GameOverSound").GetComponent<AudioSource> ().Play ();
	}
}
