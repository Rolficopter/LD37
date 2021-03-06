﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMovementScript : MonoBehaviour {

	public Transform target;
	public float speed = 0.003f;

	private float lastCollision;
	private Vector3 backwardsDirection;

	// Use this for initialization
	void Start () {
		lastCollision = float.MaxValue;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 peda = target.position - transform.position;
		Vector3 velocity;

		if (Time.time - lastCollision > 0.5f || Time.time - lastCollision < 0) {
			velocity = speed * (Vector3.Normalize (peda));
		} else {
			velocity = -speed * 3 * (Vector3.Normalize (peda));
		}
	
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = velocity;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("Player")) {
			lastCollision = Time.time;
		}
	}
}
