using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyFloatEffectScript : MonoBehaviour {

	public float amplitude = 0.005f;
	public float frequency = 3;
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, amplitude * Mathf.Sin (Time.time * frequency), 0);
	}
}
