using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Observer {

	//private vars
	private float distance = 0;
	private GameObject player; 
	//private float rotateSpeed = 1;

	//public vars
	public float distanceModifierX = 1;
	public float distanceModifierY = 1;
	public float rotation = 45;
	public float currentSize = 1;



	//TODO: set up the initial transforms to be related to the rotation variable.
	
	// Use this for initialization
	void Start () {
		//get player object as defined by player tag
		player = GameObject.FindGameObjectsWithTag("Player")[0];
		
		//move the camera exactly one distance mod unit behind and above the player
		this.transform.position += -this.transform.forward * (distanceModifierX);
		this.transform.position += this.transform.up * (distanceModifierY);
        
		//set the rotation on this camera as set in the public slider
		this.transform.Rotate(rotation,0,0);
			
		setDistance(1);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override bool notify(float size){

		return setDistance(size);

	}

	//TODO: smooth position change. lerp between positions
	private bool setDistance(float size){

		float distance = Vector3.Distance(this.transform.position ,player.transform.position);
		this.transform.position += -this.transform.forward * (distanceModifierX + size);
		//this.transform.position += this.transform.up * (distanceModifierY + size);

		return true;
	}
}
