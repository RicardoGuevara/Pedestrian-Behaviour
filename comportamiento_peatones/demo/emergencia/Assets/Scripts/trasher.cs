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
        Debug.Log("ahijue");
        if (true)
        { Destroy(col.gameObject); } 
    }
        
        
        
}
