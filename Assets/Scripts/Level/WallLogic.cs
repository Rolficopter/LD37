using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLogic : MonoBehaviour
{
	public string disappearInGroundAnimationName = "Wall_disappearInGround";
	[Range(1.0f, 10.0f)]
	public float disappearInGroundAnimationDuration = 3.0f;
	
    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {        
		
    }

	public IEnumerator RunDisappearInGroundAnimation() {
		var audio = this.GetComponent<AudioSource> ();
		audio.Play ();
		var anim = this.GetComponent<Animation> ();
		anim.Play (this.disappearInGroundAnimationName);
		// TODO: set animation duration
		yield return anim.WhilePlaying ();
		DestroyObject (this.gameObject);
	}
}
