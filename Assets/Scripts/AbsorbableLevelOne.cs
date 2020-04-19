using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbableLevelOne : Absorbable {

	
	private int sizeLevel = 1;
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
