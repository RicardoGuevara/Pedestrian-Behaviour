using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peep_motion : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.Translate(2f * Time.deltaTime, 0f, 0f);
    }
}
