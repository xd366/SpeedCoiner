using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	void Awake(){
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("Music");
		if(objs.Length >1){
			Destroy (this.gameObject);
		}
		DontDestroyOnLoad (this.gameObject);
	}
}
