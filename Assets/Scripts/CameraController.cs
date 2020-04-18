using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//private vars
	private float distance = 0;
	private GameObject player; 
	private float rotateSpeed = 1;

	//public vars
	public float distanceModifierX = 1;
	public float distanceModifierY = 1;
	public float rotation = 45;
	public float currentSize = 1;



	// Use this for initialization
	void Start () {
		//get player object as defined by player tag
		player = GameObject.FindGameObjectsWithTag("Player")[0];
		
		//set the rotation on this camera as set in the public slider
        this.transform.Rotate(rotation,0,0);
			
		setDistance(1);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool notify(float size){

		return setDistance(size);

	}

	private bool setDistance(float size){

		float distance = Vector3.Distance(this.transform.position ,player.transform.position);

		this.transform.position += -this.transform.forward * (distanceModifierX + size);
		this.transform.position += this.transform.up * (distanceModifierY + size);

		Debug.Log("this is the distance currently: " + distance);
		return true;
	}
}
