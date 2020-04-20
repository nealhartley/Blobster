using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioObserver : Observer {

	public AudioSource eatAudio;

	public override bool notify(string message){
		Debug.Log("notified to play sound");
		if(message.Equals("eating")){
			eatAudio.Play();
		}

		return true;
	}
}
