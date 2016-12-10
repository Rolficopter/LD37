using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyFloatEffectScript : MonoBehaviour {

	public float amplitude = 0.0075f;
	public float frequency = 4;

	private float randomValueA = Random.value + 0.5f;
	private float randomValueB = Random.value + 0.5f;


	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, amplitude * randomValueB * Mathf.Sin (Time.time * frequency * randomValueB), 0);
	}
}
