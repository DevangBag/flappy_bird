using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : MonoBehaviour {


    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

	// Use this for initialization
	void Start () {

        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;

	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < -groundHorizontalLength)
        { Repositionground(); }
		
	}

    private void Repositionground()
    {
        Vector2 groundoffset = new Vector2(groundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundoffset;
    }

}
