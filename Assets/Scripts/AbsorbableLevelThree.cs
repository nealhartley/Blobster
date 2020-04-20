using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelThree : Absorbable {
	
	private int sizeLevel = 3;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){
		Vector3 mass = new Vector3(0.5f, 0.5f, 0.5f);
		return mass;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	

}
