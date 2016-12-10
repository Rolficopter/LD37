using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour {
	
	void Update () {

        //Pause/Resume the Game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.isRunning())
            {
                GameManager.pauseGame();
            }else
            {
                GameManager.resumeGame();
            }
        }



	}
}
