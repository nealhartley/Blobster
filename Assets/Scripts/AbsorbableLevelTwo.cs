using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelTwo : Absorbable {

	private int sizeLevel = 2;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){
			Vector3 mass = new Vector3(0.3f, 0.3f, 0.3f);
		return mass;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	

}
