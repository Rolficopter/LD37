using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteractionManager : MonoBehaviour {

	public string pullLeverAnimationName = "Lever_pull";

	[HideInInspector()]
	public bool wasPulled;

	// Use this for initialization
	void Start () {
		wasPulled = false;
	}

	/// <summary>
	/// Runs the pull animation.
	/// </summary>
	public IEnumerator RunPullAnimation() {
		if (this.wasPulled) {
			yield break;
		}
		this.wasPulled = true;

		var anim = this.gameObject.GetComponent<Animation> ();
		anim.Play (this.pullLeverAnimationName);
		yield return anim.WhilePlaying ();
	}
}
