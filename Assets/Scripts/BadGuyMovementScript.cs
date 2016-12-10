using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMovementScript : MonoBehaviour {

	public Transform target;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (transform.position, target.position, Time.deltaTime * speed);
	}
}
