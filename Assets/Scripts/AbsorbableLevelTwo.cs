using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelTwo : Absorbable {

	private int sizeLevel = 2;
	public override int getSizeLevel(){
		return sizeLevel;
	}
	public override Vector3 getMass(){
		return this.transform.localScale;;
	}
	public override void absorb(){
		Destroy(gameObject);
	}
	

}
