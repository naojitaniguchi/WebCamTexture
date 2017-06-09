using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {
	public GameObject cubeObject ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.A) ){
			Debug.Log( "A pushed" );
			cubeObject.GetComponent<Animator>().enabled = true ;
		}
		if ( Input.GetKeyDown(KeyCode.B) ){
			Debug.Log( "B pushed" );
			cubeObject.GetComponent<Animator>().enabled = false ;
		}
	}
}
