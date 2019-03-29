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
		if (!col.gameObject.CompareTag("movil_object"))
		{ 
			tm.GetComponent<Text> ().text = info;
		} 

		if (col.gameObject.CompareTag("trash"))
		{ 
			tm.GetComponent<Text> ().text = "";
		} 
	}



}
