using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public static bool gameRunning;
    public static int enemiesKilled;
	public static int amountOfLevel;

	private static int currentLevel;
    
    public static UIHandler uiScript;

	void Start () {
        amountOfLevel = 2;
		currentLevel = 0;

        gameRunning = true;
        uiScript = GetComponent<UIHandler>();
        uiScript.updateText();
	}

    //Pause the Game
    public static void pauseGame()
    {
        if (gameRunning)
        {
            gameRunning = false;
        }
    }

    //Resume the Game
    public static void resumeGame()
    {
        if (!gameRunning)
        {
            gameRunning = true;
        }
    }


    //Go to Next Level
    public void nextLevel()
    {
        //Check if Last Level
		if ((getCurrentLevel ()) == amountOfLevel) {
			//Winning Screen
			Debug.Log ("You won!");
		} else {
            //Set Current Level To Next Level
            setCurrentLevel(getCurrentLevel() + 1);
            //Destroy every GameObject with Tag ("Level+currentLevel")
			string tag = "RemoveFor_Level" + (getCurrentLevel() + 1);
            var objectsToDestroy = GameObject.FindGameObjectsWithTag(tag);
            foreach(var obj in objectsToDestroy)
            {
                DestroyObject(obj);
            }
        }
    }

    //Change Current Level
    public static void setCurrentLevel(int lvl) {
		if (lvl > 0 || lvl < amountOfLevel) {
			currentLevel = lvl;
			uiScript.updateText ();
		} else {
			Debug.LogWarningFormat ("Invalid level index: {1}", lvl);
		}
    }
    //Get the Current Level
    public static int getCurrentLevel() { return currentLevel; }

    //Change the Amount of Enemies Killed
    public static void setEnemiesKilled(int v) {
        enemiesKilled = v;
        uiScript.updateText();
    }
    //Get the amount of Enemies Killed
    public static int getEnemiesKilled() { return enemiesKilled; }

    //Get wether the the game is running or paused
    public static bool isRunning()
    {
        return gameRunning;
    }
}
