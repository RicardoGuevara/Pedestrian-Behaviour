using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public float probability;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		//Debug.Log("contacto detectado");
		if (col.gameObject.CompareTag("movil_object"))
		{ 
			int dec = Random.Range(0, 100);
			if (dec < probability)
				col.transform.rotation = transform.rotation;
		} 
	}
}
