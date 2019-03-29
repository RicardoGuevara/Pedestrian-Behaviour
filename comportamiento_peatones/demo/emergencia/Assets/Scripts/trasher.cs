using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trasher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("colision detectada");
        Destroy(col.gameObject);
    }
        
	void OnTriggerEnter(Collider col)
	{
		//Debug.Log("contacto detectada");
		if (!col.gameObject.CompareTag("MainCamera"))
		{ 
			Destroy(col.gameObject);
		} 

	}    
        
}
