using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomando : MonoBehaviour {
    public Animator anim;
    // Use this for initialization
    void Start () {
        Invoke("animaciones", 9);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void animaciones()
    {
        anim.SetFloat("Dejar de tomar", 1.0f);
    }
}
