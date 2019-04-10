using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class democine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Animator>().Play("CameraRoll",-1,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
