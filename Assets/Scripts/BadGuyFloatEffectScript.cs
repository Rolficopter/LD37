using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyFloatEffectScript : MonoBehaviour {

	public float amplitude = 0.0075f;
	public float frequency = 4;
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, amplitude * (Random.value + 0.5f) * Mathf.Sin (Time.time * frequency * (Random.value + 0.5f)), 0);
	}
}
