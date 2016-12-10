using UnityEngine;
using System.Collections;

public class GAME_GameManager : MonoBehaviour {


    public static bool gameRunning;
    public static int currentLevel;
    public static int enemiesKilled;

    public static GAME_UIHandler uiScript;

	void Start () {
        gameRunning = true;
        currentLevel = 1;
        uiScript = GetComponent<GAME_UIHandler>();
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

    //Change Current Level
    public static void setCurrentLevel(int lvl){
        currentLevel = lvl;
        uiScript.updateText();
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
