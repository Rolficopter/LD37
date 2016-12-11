using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLevelManager : MonoBehaviour
{
	public int GetNumberOfLevels() {
		return this.levelScripts.Length;
	}
	public MonoBehaviour[] levelScripts;

	private int currentLevel;

	// Use this for initialization
	void Start ()
	{
		this.SetCurrentLevel (0);

		if (this.GetNumberOfLevels() < 1) {
			Debug.LogError ("Number of levels is lower than 1!");
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	#region Changing the level

	/// <summary>
	/// Gos to next level.
	/// </summary>
	public void GoToNextLevel ()
	{
		int nextLevel = this.GetCurrentLevel () + 1;

		if (nextLevel >= this.GetNumberOfLevels() ) {
			//Debug.Log ("You won!");
			return;
		} 
			
		if (!this.SetCurrentLevel (this.currentLevel + 1)) {
			return;
		}


		var objectsToRemove = GameObject.FindGameObjectsWithTag ("RemoveFor_Level" + (nextLevel + 1));
		float longestWallRemovalTime = 0.0f;
		foreach (var obj in objectsToRemove) {

			var wall = obj.GetComponent<WallLogic> ();
			if (wall != null) {
				StartCoroutine(wall.RunDisappearInGroundAnimation ());

				if (longestWallRemovalTime < wall.disappearInGroundAnimationDuration) {
					longestWallRemovalTime = wall.disappearInGroundAnimationDuration;
				}
			}
		}
		CameraShake cs = FindObjectOfType<CameraShake> ();
		cs.StartShake (longestWallRemovalTime);
	}

	/// <summary>
	/// Sets the current level.
	/// </summary>
	/// <returns><c>true</c>, if current level was set, <c>false</c> otherwise.</returns>
	/// <param name="level">Level.</param>
	public bool SetCurrentLevel (int level)
	{
		if (level < 0 || level >= this.GetNumberOfLevels() ) {
			Debug.LogWarningFormat ("Invalid level index: {0}", level);
			return false;
		}

		if (this.levelScripts [this.currentLevel] != null) {
			//this.levelScripts [this.currentLevel].LevelBecameInactive ();
			((LevelBehavior)this.levelScripts [this.currentLevel]).LevelBecameInactive ();
		}
		this.currentLevel = level;
		if (this.levelScripts [this.currentLevel] != null) {
			//this.levelScripts [this.currentLevel].LevelBecameActive ();
			((LevelBehavior)this.levelScripts [this.currentLevel]).LevelBecameActive();
		}

		return true;
	}

	/// <summary>
	/// Gets the current level.
	/// </summary>
	/// <returns>The current level.</returns>
	public int GetCurrentLevel ()
	{
		return this.currentLevel;
	}

	#endregion
}
