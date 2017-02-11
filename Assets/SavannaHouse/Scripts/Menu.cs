using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {

		if(Input.GetKey(KeyCode.Keypad0)){
			Application.LoadLevel(0);
		}
		if(Input.GetKey(KeyCode.Keypad1)){
			Application.LoadLevel(1);
		}
		if(Input.GetKey(KeyCode.Keypad2)){
			Application.LoadLevel(2);
		}
	}
}
