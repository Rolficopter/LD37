using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAnimator : MonoBehaviour {

	public string pullLeverAnimationName = "Lever_pull";

	private bool wasAnimated;

	// Use this for initialization
	void Start () {
		wasAnimated = false;
	}

	/// <summary>
	/// Runs the pull animation.
	/// </summary>
	public void RunPullAnimation() {
		if (this.wasAnimated) {
			return;
		}
		this.wasAnimated = true;

		this.gameObject.GetComponent<Animation>().Play (this.pullLeverAnimationName);
	}
}
