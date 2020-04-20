using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelFour : Absorbable {
	
	private int sizeLevel = 4;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){
		Vector3 mass = new Vector3(0.7f, 0.7f, 0.7f);
		return mass;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	

}
