using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Fire1") || Input.GetKey(KeyCode.Space)) {
			SceneManager.LoadSceneAsync ("Menu", LoadSceneMode.Single);
		}
	}
}
