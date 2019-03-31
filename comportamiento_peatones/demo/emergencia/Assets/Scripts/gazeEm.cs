using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeEm : MonoBehaviour {

	public GameObject tm;
	public string info;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.CompareTag("MainCamera"))
		{ 
			tm.GetComponent<Text> ().text = info;
		} 
	}

	void OnTriggerExit(Collider col)
	{
		tm.GetComponent<Text> ().text = "";
	}

}
