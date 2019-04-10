using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinematicintro : MonoBehaviour {
	
	void Start () {
		//this.GetComponent<Animator>().Play("CameraRoll",-1,0.0f);


	}

	bool generalsw =true;
	bool onrotate =false;
	int rot = 0;
	
	// Update is called once per frame
	void Update () {
		if (generalsw) {
			if (!onrotate) {
				transform.Translate (10f * Time.deltaTime, 0f, 0f);
			} else {
				if (rot < 2500f*Time.deltaTime) {
					gameObject.transform.Rotate (0f, 15f * Time.deltaTime, 0f);
					rot++;
				} else {
					gameObject.transform.SetPositionAndRotation (new Vector3 (-38.8f, 1.9f, -32.5f), new Quaternion (0f, 0f, 0f, 0f));
					generalsw = false;
				}
			}
		}
	}


	void OnTriggerEnter(Collider col)
	{
		//Debug.Log("contacto detectado");
		/*
		if (col.gameObject.CompareTag("stop"))
		{ 
			onrotate = true;

			for(int i=0;i < 900;i++){
				gameObject.transform.Rotate(0f,0.1f*Time.deltaTime,0f);
			}

			onrotate = false;
		} 
		*/

		onrotate = true;
	}
}
