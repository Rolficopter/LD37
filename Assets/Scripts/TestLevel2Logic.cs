using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevel2Logic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (GoToLevel2 ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator GoToLevel2() {
		yield return new WaitForSeconds (10);

		var objectsToRemove = GameObject.FindGameObjectsWithTag ("RemoveFor_Level2");
		foreach (var obj in objectsToRemove) {
			DestroyObject (obj);
		}
	}
}
