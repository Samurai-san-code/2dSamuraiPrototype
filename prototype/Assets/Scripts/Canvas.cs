using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public Transform transformit;
    public Text scoreText;
    private int scoretodisplay;
    public BoxCollider2D collider;
    public Rigidbody2D myBody;
    private bool isFalling = false;





    // Start is called before the first frame update
    void Start()
    {
        
        scoretodisplay = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretodisplay = (int)transformit.position.y;
        scoreText.text = "Score : " + scoretodisplay;

        if (myBody.velocity.y < -0.1)
        {
            isFalling = true;
        }
        else
        {
            isFalling = false;
        }
        
        if (isFalling)
        {
            collider.isTrigger = false;
        }
        else
        {
            collider.isTrigger = true;
        }

        
    }
}
