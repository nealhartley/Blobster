using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Observer : MonoBehaviour {

	abstract public bool notify(float size);

}
