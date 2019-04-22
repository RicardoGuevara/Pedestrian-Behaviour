using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spriteChange : MonoBehaviour {

	public Image imagen;
	public Sprite sprite_nuevo;
	public string tag;
	public bool destroyimage; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag (tag)) {
			if (destroyimage)
				Destroy (imagen);
			else
				imagen.sprite = sprite_nuevo;
		}
	}
}
