using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME_Portal : MonoBehaviour {

    public GameObject portalExit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            float playerYScale = other.gameObject.transform.lossyScale.y;
            other.gameObject.transform.position = new Vector3(portalExit.transform.position.x, portalExit.transform.position.y + playerYScale, portalExit.transform.position.z);
        }
    }
}
