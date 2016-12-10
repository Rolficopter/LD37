using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeInteractionManager : MonoBehaviour {

	[Range(0, 10)]
	public float interactionDistance = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		if (Input.GetKeyUp (KeyCode.E)) {
			RaycastHit hit;
			Vector3 forward = this.transform.TransformDirection (Vector3.forward);
			if (Physics.Raycast (transform.position, forward, out hit, this.interactionDistance)) {
				//Debug.LogFormat ("Hit {0} at distance {1}", hit.collider.gameObject, hit.distance);

				GameObject lever = hit.collider.gameObject;
				if (lever.tag == "Lever") {
					var animator = lever.GetComponent<LeverAnimator> ();
					if (animator != null) {
						animator.RunPullAnimation ();
					}
				}
			}
		}
	}
}
