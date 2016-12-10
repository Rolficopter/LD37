using UnityEngine;
using System.Collections;

public class GAME_KeyHandler : MonoBehaviour {
	
	void Update () {

        //Pause/Resume the Game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GAME_GameManager.isRunning())
            {
                GAME_GameManager.pauseGame();
            }else
            {
                GAME_GameManager.resumeGame();
            }
        }



	}
}
