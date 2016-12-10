using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMovementScript : MonoBehaviour {

	public Transform target;
	public float speed = 0.003f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 peda = target.position - transform.position;
		Vector3 newPosition = transform.position + speed * (Vector3.Normalize(peda));
		transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
	}
}
