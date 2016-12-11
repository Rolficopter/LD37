using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelBehavior : MonoBehaviour {

	private bool isLevelActive = false;

	// Use this for initialization
	public void Start () {

	}

	protected abstract void LevelStart ();
	
	// Update is called once per frame
	public void Update () {
		if (!this.isLevelActive) {
			return;
		}

		this.UpdateLevel ();
	}

	/// <summary>
	/// Updates the level.
	/// </summary>
	protected abstract void UpdateLevel ();

	public virtual void LevelBecameActive() {
		this.isLevelActive = true;

		this.LevelStart ();
	}
	public virtual void LevelBecameInactive() {
		this.isLevelActive = false;
	}
}
