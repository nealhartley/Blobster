using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorptionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//onEnter 
		//checks if something has entered the "eating zone" and will then call required functions if they have.

	//canEat -> boolean
		//takes an object and checks whether it can be absorbed by the current object

	//calc currentmass -> level
		//works out the current mass of this object and equates that to a level it is allowed to eat

	//absorb 
		// destroys the object it is absorbing

	//notify observers
		// let all observers know that they need updating

}
