//
// LC VR Kit Ex
//
// Copyright (c) 2015 Laurel Code Inc.
// All rights reserved.
//
// Contact: Laurel Code Inc. (support@laurel-code.com)
//


using UnityEngine;


public class LCVRAutoShot : MonoBehaviour
{
	[SerializeField] private GameObject prefab;

	[SerializeField] private float interval =  4.0f;
	[SerializeField] private float velocity = 15.0f;
	
	private float elapsedTime = 0.0f;
	
	private void Update(){
		elapsedTime += Time.deltaTime;

		if (elapsedTime >= interval){
			GameObject clone = Instantiate<GameObject>(prefab);

			clone.name = prefab.name;

			clone.transform.position = transform.position;
			clone.transform.rotation = transform.rotation;

			clone.GetComponent<Rigidbody>().velocity = transform.forward * velocity;

			elapsedTime = 0.0f;
		}
	}
}
