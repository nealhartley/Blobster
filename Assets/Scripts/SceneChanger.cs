using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseClick(){
		Debug.Log("Clicked");
		SceneManager.LoadScene("CameraTest", LoadSceneMode.Single);
	}
}
