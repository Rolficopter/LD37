using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeInteractionManager : MonoBehaviour {

	[Range(0, 10)]
	public float interactionDistance = 1.5f;

	private bool canInteract;
	private GameObject currentLever;

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
		if (currentLever != null) {
			StartCoroutine(this.PullLever (currentLever));
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Lever") {
			currentLever = other.gameObject;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Lever") {
			currentLever = null;
		}
	}

	private IEnumerator PullLever(GameObject lever) {
		this.canInteract = false;

		var animator = lever.GetComponent<LeverInteractionManager> ();
		if (animator.wasPulled) {
			this.canInteract = true;
			yield break;
		}

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
