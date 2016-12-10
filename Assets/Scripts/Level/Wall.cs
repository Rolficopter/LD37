using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private bool disappear;

    float duration = 1.0f;
    float speed = 0.5f;

    // Use this for initialization
    void Start()
    {
        disappear = false;
        positionStart = this.transform.position;

    }
    private float deltaSum = 0f;
    private Vector3 positionStart;
    // Update is called once per frame
    void Update()
    {
        deltaSum += Time.deltaTime;
        if (disappear)
        {
            Vector3 newPos = positionStart;
            //TODO: funky mathematical thinking
            newPos.y += (deltaSum / duration) * (-speed);
            this.transform.position = newPos;

        }

    }
    void RemoveWall()
    {

        this.disappear = true;

    }
}
