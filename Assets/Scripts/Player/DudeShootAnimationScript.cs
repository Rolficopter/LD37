using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeShootAnimationScript : MonoBehaviour {
	public float animationDuration = 1;

	private float animationStart;
	private bool shot = false;
	private Vector3 startPosition;
	private Quaternion startRotation;

	// Use this for initialization
	void Start () {
		animationStart = 0;
		startPosition = transform.localPosition;
		startRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		float passedTime = Time.time - animationStart;
		if (passedTime < animationDuration && shot) {
			float x = 45 * Mathf.Sin ((passedTime / animationDuration) * Mathf.PI);
			transform.localRotation = Quaternion.Euler (x, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
			float x2 = 0.1f * Mathf.Sin ((passedTime / animationDuration) * 2 * Mathf.PI);
			transform.localPosition = new Vector3 (startPosition.x, startPosition.y, startPosition.z - x2);
		} else if (Input.GetButtonDown ("Fire1")) {
			animationStart = Time.time;
			shot = true;
		} else {
			transform.localPosition = startPosition;
			transform.localRotation = startRotation;
		}
	}
}
