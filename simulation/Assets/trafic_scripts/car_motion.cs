using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_motion : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        transform.Translate(20f * Time.deltaTime, 0f, 0f);
    }
}
