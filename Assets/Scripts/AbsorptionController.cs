using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorptionController : MonoBehaviour {
	public Observer[] observers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider other){
		bool canEat = this.canEat(other);
	}

	//onEnter 
		//checks if something has entered the "eating zone" and will then call required functions if they have.

	//canEat -> boolean
	private bool canEat(Collider other){
		//takes an object and checks whether it can be absorbed by the current object
		int currLvl = currentMassAsLevel();

		if(currLvl < other.GetComponents()){
			//TODO: need to instantiate an object script that contains a method for fetching thier size level
			return false;
		}
		return true;
	}
		

	//calc currentmass -> level
	private int currentMassAsLevel(){
		//works out the current mass of this object and equates that to a level it is allowed to eat
		return 1;
	}

	private int currentMassAsFloat(){
		return 1;
	}
		

	//absorb 
		// destroys the object it is absorbing

	//notify observers
	void notify () {	
		// let all observers know that they need updating

		foreach(Observer i in observers){
			i.notify(currentMassAsFloat());
		}
		
	}
		
}
