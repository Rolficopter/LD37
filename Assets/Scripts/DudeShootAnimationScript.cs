using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeShootAnimationScript : MonoBehaviour {
	public float animationDuration = 1;

	private float animationStart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			animationStart = Time.time;
		}

		float passedTime = Time.time - animationStart;
		if (passedTime < animationDuration) {
			float x = 45 * Mathf.Sin ((passedTime/animationDuration)*Mathf.PI);
			transform.localRotation = Quaternion.Euler(x, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
		}
	}
}
