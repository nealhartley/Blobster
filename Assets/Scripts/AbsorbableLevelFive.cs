using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelFive : Absorbable {
	
	private int sizeLevel = 5;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){
		Vector3 mass = new Vector3(1f, 1f, 1f);
		return mass;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	

}
