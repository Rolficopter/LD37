using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteractionManager : MonoBehaviour {

	public string pullLeverAnimationName = "Lever_pull";

	private bool wasAnimated;

	// Use this for initialization
	void Start () {
		wasAnimated = false;
	}

	/// <summary>
	/// Runs the pull animation.
	/// </summary>
	public IEnumerator RunPullAnimation() {
		if (this.wasAnimated) {
			yield return null;
		}
		this.wasAnimated = true;

		var anim = this.gameObject.GetComponent<Animation> ();
		anim.Play (this.pullLeverAnimationName);
		yield return anim.WhilePlaying ();
	}
}
