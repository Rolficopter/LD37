using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME_NextLevelPlatform : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {

        //Check if Player is entering the Trigger
        if(other.gameObject.tag == "Player")
        {
            //Continue to next Level
            GameObject gm = GameObject.FindGameObjectWithTag("GameManager");
            GAME_GameManager gmScript = gm.GetComponent<GAME_GameManager>();
            gmScript.nextLevel();
            Destroy(this.gameObject);
        }
    }

}
