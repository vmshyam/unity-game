using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMoveProperties : MonoBehaviour {

    public float trackSpeed;
    Vector2 textureOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        textureOffset = new Vector2 (0, Time.time * trackSpeed);
        GetComponent<Renderer>().material.mainTextureOffset = textureOffset;

	}
}
