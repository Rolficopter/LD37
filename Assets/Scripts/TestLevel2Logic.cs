using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevel2Logic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(NextLevel("Level2", 3));
		StartCoroutine(NextLevel("Level3", 6));
		StartCoroutine(NextLevel("Level4", 9));
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
	}
}
