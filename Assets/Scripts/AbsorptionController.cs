using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorptionController : MonoBehaviour {

	public float scaleFactor = 0.1f;

	private Vector3 currMass;
	private Vector3 goalMass;
	private Absorbable absorbScript; //the script for whatever we bumped into
	public Observer[] observers;
	// Use this for initialization
	void Start () {
		currMass = this.transform.localScale;
		goalMass = currMass;
		Debug.Log("current mass: " + currMass);
	}
	
	// Update is called once per frame
	void Update () {
		grow();
	}

	private void OnTriggerEnter(Collider other){

		Debug.Log("on trigger enter");

		bool canEat = this.canEat(other);
		if(canEat){
			Vector3 toAbsorb = absorbScript.getMass(); // get their mass 
			
			goalMass = goalMass + toAbsorb; //add to the goal mass so we begin scale cycle

			absorbScript.absorb();//call their method to destroy them.
		}
	}



	//canEat -> boolean
	private bool canEat(Collider other){
		//takes an object and checks whether it can be absorbed by the current object
		int currLvl = currentMassAsLevel();
		
		//get the sizeLevel of the object that has been bumped into
		absorbScript = other.GetComponent<Absorbable>();

		Debug.Log("Blob size Level: " + currLvl + "- other object level: " +  absorbScript.getSizeLevel());

		if(currLvl < absorbScript.getSizeLevel()){
			//TODO: need to instantiate an object script that contains a method for fetching thier size level
			Debug.Log("just hit something we cant absorb");	
			return false;
		}
		Debug.Log("just hit something we will absorb");	
		return true;
	}
		

	//calc currentmass -> level
	private int currentMassAsLevel(){
		//works out the current mass of this object and equates that to a level it is allowed to eat
		return (int)currMass.y;
	}

	private Vector3 currentMassAsVector3(){
		return currMass;
	}
		

	//absorb 
		// destroys the object it is absorbing

	//notify observers
	void notify () {	
		// let all observers know that they need updating

		foreach(Observer i in observers){
			//i.notify(currentMassAsFloat());
		}
		
	}

	// method that scales the monster per update. until it reach goal Mass
	public void grow(){
		if(currMass.y >= goalMass.y){
			return; // if we are already at desired size just return
		} 

		this.transform.localScale += new Vector3(scaleFactor,scaleFactor, scaleFactor);
		currMass = this.transform.localScale;//update current scale

	}
		
}
