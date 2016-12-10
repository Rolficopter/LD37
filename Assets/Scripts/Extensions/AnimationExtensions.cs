using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationExtensions {

	public static IEnumerator WhilePlaying( this Animation animation) {
		yield return new WaitUntil( () => !animation.isPlaying );
	}

}
