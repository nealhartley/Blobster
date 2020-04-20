using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelOne : Absorbable {

	
	private int sizeLevel = 1;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){

		Vector3 mass = new Vector3(0.1f, 0.1f, 0.1f);
		return mass;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	


}
