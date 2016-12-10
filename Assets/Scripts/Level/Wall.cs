using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private bool disappear;

    private float duration = 3.0f;  
    private float distance = 10f;

    private Vector3 positionEnd;
    

    // Use this for initialization
    void Start()
    {
        disappear = false;
        positionStart = this.transform.position;
        positionEnd = new Vector3(0, - distance, 0);
    }
    private float deltaSum = 0f;
    private Vector3 positionStart;
    // Update is called once per frame
    void Update()
    {        
        if (disappear)
        {
            deltaSum += Time.deltaTime;
            float progress = deltaSum / duration;           
            Vector3 newPos = positionStart + progress * positionEnd;
           
            this.transform.position = newPos;

        }

    }
    void RemoveWall(float duration)
    {
        this.duration = duration;
        this.disappear = true;
		CameraShake cs = FindObjectOfType<CameraShake> ();
    }
}
