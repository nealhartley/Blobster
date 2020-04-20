using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observerTest : MonoBehaviour {

	public Observer[] observers;
	public int updateFrameLapse = 200; //skip this many frames before notifying observers

	private int count = 0;
	private float size = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(count < updateFrameLapse){
			count ++;
			return;
		}
		
		foreach(Observer i in observers){
			i.notify(size.ToString());
		}
		count = 0;
		size++;
	}
}
