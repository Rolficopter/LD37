using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelPlatform : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        //Check if Player is entering the Trigger
        if(other.gameObject.tag == "Player")
        {
            //Continue to next Level
            GameObject gm = GameObject.FindGameObjectWithTag("GameManager");
			RoomLevelManager roomMgr = gm.GetComponent<RoomLevelManager> ();
			roomMgr.GoToNextLevel ();
            
			// remove the trigger
			Destroy(this.gameObject);
        }
    }

}
