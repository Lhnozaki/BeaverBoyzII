using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling_ground : MonoBehaviour
{
    private float length, startPos;
    public float groundSpeed;
    //public int tileSize, numTiles;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        //
        //Debug.Log(length);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x <= -4)
        {
            transform.Translate(8, 0f, 0f);
        }
        else
        {
            Debug.Log(transform.position.x);
            transform.Translate(-groundSpeed, 0f, 0f);
        }
    }
}
