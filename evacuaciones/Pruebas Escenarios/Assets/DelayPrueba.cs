using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayPrueba : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {

        Invoke("animaciones", 5);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void animaciones() {
        anim.SetFloat("comenzar", 1.0f);
    }
}
