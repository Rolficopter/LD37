using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeInteractionManager : MonoBehaviour {

	[Range(0, 10)]
	public float interactionDistance = 1.5f;

	private bool canInteract;

	// Use this for initialization
	void Start () {
		this.canInteract = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E) && this.canInteract) {
			this.TryPullLever ();
		}
	}

	private void TryPullLever() {
		RaycastHit hit;
		Vector3 forward = this.transform.TransformDirection (Vector3.forward);

		Debug.LogFormat ("Searching for levers at distance {0}", this.interactionDistance);
		if (Physics.Raycast (transform.position, forward, out hit, this.interactionDistance)) {
			// hit a collider at distance y

			GameObject lever = hit.collider.gameObject;
			Debug.Log (lever);
			if (lever.tag == "Lever") {
				StartCoroutine(this.PullLever (lever));
			}
		}
	}

	private IEnumerator PullLever(GameObject lever) {
		this.canInteract = false;

		var animator = lever.GetComponent<LeverInteractionManager> ();
		yield return StartCoroutine (animator.RunPullAnimation ());
		this.ActivateNextLevel ();

		this.canInteract = true;
	}

	private void ActivateNextLevel() {
		// Continue to next Level
		GameObject gm = GameObject.FindGameObjectWithTag("GameManager");
		RoomLevelManager roomMgr = gm.GetComponent<RoomLevelManager> ();
		roomMgr.GoToNextLevel ();
	}
}
