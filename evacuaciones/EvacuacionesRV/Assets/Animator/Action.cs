using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z <= -43 && this.transform.position.z>-45) {
            anim.SetFloat("Active", 1.0f);
        }
        if (this.transform.position.z <= -45) {
            anim.SetFloat("Active", 0.0f);
        }
        
	}
   
}
