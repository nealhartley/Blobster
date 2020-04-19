using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Absorbable : MonoBehaviour {

	private int sizeLevel;
	public abstract int getSizeLevel();
	public abstract Vector3 getMass();
	public abstract void absorb();
	
}
